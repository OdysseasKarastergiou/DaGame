using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trumpSomethinMove : MonoBehaviour {

    public GameObject trump;
    public Transform target1, target2, target3;
    public static int movSpeed = 1;
    public bool shit;
    Animator anim;
    // Use this for initialization
    void Start () {
        shit = true;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (shit == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1.position, movSpeed * Time.deltaTime);
        }

        if (transform.position == target1.position)
        {
            shit = false;

        }

        if (shit == false)
        {

            anim.SetTrigger("trumpStop");
             
        }

        Invoke("neeext", 8.0f);
 
    }

    public void neeext()
    {
        SceneManager.LoadScene("Level2");
    }
}
