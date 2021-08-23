using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewpewCollision : MonoBehaviour
{

    public GameObject pew;

    // Use this for initialization
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Tmove tmove = collision.collider.GetComponent<Tmove>();
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(pew);
        }
        if (collision.gameObject.CompareTag("bkg"))
        {
            Destroy(pew);
        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            Destroy(pew);

        }


    }

}