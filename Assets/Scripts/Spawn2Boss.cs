using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn2Boss : MonoBehaviour
{

    public GameObject Boss;
 
    public Slider Slider;
 








    public Vector2 offset = new Vector2(0.2f, 0.1f);

    public bool collided;
    // Use this for initialization
    void Start()
    {

        Boss.SetActive(false);
        Slider = GameObject.Find("Slider").GetComponent<Slider>();
        Slider.gameObject.SetActive(false);
        collided = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (collided == true)
        {
            Invoke("EnableBoss", 5.0f);
            Slider.gameObject.SetActive(true);

        }

   


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collided = true;
        }
    }


    public void EnableBoss()
    {
        Boss.SetActive(true);

    }







}
