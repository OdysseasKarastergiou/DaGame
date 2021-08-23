using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn2 : MonoBehaviour {

    public GameObject enemy;
    public GameObject Boss;
    public GameObject Machete,Machete2;
    public Slider Slider;
    public GameObject nextLev;
     
    



  


    public Vector2 offset = new Vector2(0.2f, 0.1f);

    public bool collided;
    // Use this for initialization
    void Start()
    {

        nextLev.SetActive(false); 
        Boss.SetActive(false);
        Machete.SetActive(false);
        Slider = GameObject.Find("TheSlider").GetComponent<Slider>();

  
        Machete2.SetActive(false);
        collided = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(collided == true)
        {
            Invoke("EnableMachete", 15.0f);
            Invoke("EnableBoss", 20.0f);
         
        }

      
    }

    public void Shooting2()
    {


       

            Instantiate(enemy, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
      
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collided = true;
            InvokeRepeating("Shooting2", 7.0f, 3.0f);

             
        }

    }

    public void EnableBoss()
    {
        Boss.SetActive(true);
        Slider.gameObject.SetActive(true);

    }
    public void EnableMachete()
    {
        Machete.SetActive(true);
        Machete2.SetActive(true);
    }

   

   

 

}
