using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject enemy;

    public Vector2 offset = new Vector2(0.2f, 0.1f);

    public bool collided;
    // Use this for initialization
    void Start () {
        collided = false;
    
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void Shooting()
    {

            Instantiate(enemy, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            InvokeRepeating("Shooting", 5.0f, 3.0f);
        }

    }


}
