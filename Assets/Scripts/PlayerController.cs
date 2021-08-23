using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    //movement
    public float speed;
    public float jump;
    private float moveInput;

    private Rigidbody2D rb;
    private bool faceRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatisGround;

    private int extraJump;
    public int extraJumpValue;

    //combat
    public int health = 3;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public GameObject hpUP;
    public GameObject hpUp1;

    public GameObject tequila, tequila2;
   

    private Animator anim;

    public Text tipText;
    public Text specialText;

    public SlowMo slowMo;
    public int slowCount = 0;
    public int slowCountR = 2;

    public GameObject nextLevel;

    private static GameMaster instance;
 






    // Use this for initialization
    void Start () {

  
        anim = GetComponent<Animator>();
        extraJump = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();
        
	}

     void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatisGround);

        moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        //taxuthta , rb velocity y /gia na parameinei ston aksona y

        if(faceRight == false && moveInput > 0)
        {
            //ama to input einai 1 ara deksia, koitaei deksia
            Flip();
        }else if(faceRight == true && moveInput < 0)
        {  //antitheto
            Flip();
        }
    }

    void Flip()
    {
        
        faceRight = !faceRight;
        Vector3 Scaler = transform.localScale; // pou vrisketai 
        Scaler.x *= -1; //* -1 ton aksona x tou montelou wste na gurisei
        transform.localScale = Scaler;
    }
    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetTrigger("isWalk");
        }
        else
        {
            anim.SetTrigger("isIdle");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetTrigger("isJump");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("isShoot");
        }

        if (isGrounded == true)
        {
            extraJump = extraJumpValue; // posa jump epitrepetai ama einai katw
        }
		if(Input.GetKeyDown(KeyCode.UpArrow) && extraJump > 0) //me to panw velaki jump 
        {
            rb.velocity = Vector2.up * jump; 
            extraJump--;
        }else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jump;
        }


        if (Input.GetKeyDown(KeyCode.LeftControl))
            if (slowCount == 0||slowCount == 1||slowCount == 2||slowCount ==3||slowCount ==4||slowCount==5)
            {
                {
                    slowMo.slowMotion();
                }
                slowCount++;
                slowCountR--;
                specialText.text = "Special Left : " + slowCountR.ToString();
            }
            else
            {
                return;
            }
        
	}



    void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.gameObject.tag == "hpP")
        {
            notHurt();

        }
        if (collision.gameObject.tag == "hpP1")
        {
            notHurt2();
        }

        if(collision.gameObject.tag == "tequila")
        {
            slowCountR++;
            slowCount++;
            specialText.text = "Special Left : " + slowCountR.ToString();
            Destroy(tequila);
            
            anim.SetTrigger("isDrink");
        }

        if (collision.gameObject.tag == "tequila2")
        {
            slowCountR++;
            slowCount++;
            specialText.text = "Special Left : " + slowCountR.ToString();
            Destroy(tequila2);

            anim.SetTrigger("isDrink");
        }


        if (collision.tag == "spike")
            {
           
            Application.LoadLevel("DeathScreen");
             

        }

        if (collision.gameObject.tag == "NextLevel")
        {
            SceneManager.LoadScene("Level2");
        }

        
        
    }

   

    public void Hurt()
    {
        
        health--; 
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

        }
        if (health <= 0)
        {
            Application.LoadLevel("DeathScreen");
            
        }
    }



    public void notHurt()
    {
        if (health == 3)
        {
            return;
        }
        else
        {
            health++;
            disableHpUp();
           
            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < health)
                {
                    hearts[i].enabled = true;
                }
                else
                {
                    hearts[i].enabled = false;
                }
            }
            
        }
    }

    public void notHurt2()
    {
        if (health == 3)
        {
            return;
        }
        else
        {
            health++;
            disableHpUp1();

            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < health)
                {
                    hearts[i].enabled = true;
                }
                else
                {
                    hearts[i].enabled = false;
                }
            }

        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        Tmove tmove = collision.collider.GetComponent<Tmove>();
        EnemyPewCollision autopewpew = collision.collider.GetComponent<EnemyPewCollision>();
        spawn3Move machette = collision.collider.GetComponent<spawn3Move>();
        BossPewColl taco = collision.collider.GetComponent<BossPewColl>();
        BossShoot sut = collision.collider.GetComponent<BossShoot>();
        
        if (tmove != null||autopewpew!=null||machette!=null||taco!=null||sut!=null)
        {
            Hurt();
         
            anim.SetTrigger("isHit");
            
        }

    }

    public void disableHpUp()
    {
        hpUP.SetActive(false);
        
    }
    public void disableHpUp1()
    {
        hpUp1.SetActive(false);
    }

   

 
}
