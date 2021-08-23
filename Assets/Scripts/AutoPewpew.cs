using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPewpew : MonoBehaviour {

    public GameObject projectile;
    public Vector2 velocity;
    public Vector2 offset = new Vector2(0.2f, 0.1f);

    private float shotDelay;
    public float startShotDelay;



    // Use this for initialization
    void Start()
    {
        shotDelay = startShotDelay;
    }

    // Update is called once per frame

       
    void Update()
    {
        if (shotDelay <= 0)
        {
            GameObject go1 = Instantiate(projectile,(Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
            go1.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * velocity.x;
            shotDelay = startShotDelay;
          

        }
        else
        {
            shotDelay -= Time.deltaTime;
        }
    }


}
