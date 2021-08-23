using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss2F : MonoBehaviour
{

    public int health;
    public int maxHealth = 10;
    public Slider healthBar;
    public Text hpPerc;
    public GameObject pauseMenuUI;

    public float startTimeBtwShots;
    private float timeBtwShots;

    public GameObject shot;
    private Transform player;

    private Animator anim;
    public GameObject Boss;

    public bool nextPls;
    float timeLeft = 5.0f;


    // Use this for initialization
    void Start()
    {
 
        anim = GetComponent<Animator>();
        hpPerc.text = health.ToString();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nextPls = false;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;


        if (timeBtwShots <= 0)
        {
            Instantiate(shot, transform.position, Quaternion.identity); 
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

        if (nextPls == true)
        {
            Invoke("Neext", 3.0f);

        }
        Debug.Log(nextPls);
    }

    public void Hurt()
    {
        health--; //sto hit -1 hp
        hpPerc.text = health.ToString();



        if (health < 1) 
        {

            nextPls = true;
            anim.SetTrigger("b2isDead");
  
             
          




            Destroy(Boss,4f);
            healthBar.gameObject.SetActive(false);
            Destroy(shot);





        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        pewpewCollision pewKill = collision.collider.GetComponent<pewpewCollision>();
        if (pewKill != null)
        {
            Hurt();

        }
    }

    public void Neext()
    {
        SceneManager.LoadScene("EndScene");
    }

}
