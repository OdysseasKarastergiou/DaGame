using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPewColl : MonoBehaviour {

    public GameObject pew;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        AutoPewpew tmove = collision.collider.GetComponent<AutoPewpew>();

    

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(pew);

        }
        else if (collision.gameObject.CompareTag("Enemy")||collision.gameObject.CompareTag("bkg"))
        {
            Destroy(pew);
        }




    }
}
