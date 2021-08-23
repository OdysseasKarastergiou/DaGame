using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameAnim : MonoBehaviour {


    public GameObject trump;
    public GameObject mel;
    public Transform target1, target2, target3;
    

    public static int movSpeed = 2;
    public Vector3 userDir = Vector3.up;

    public bool crap;
	// Use this for initialization
	void Start () {

        crap = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (crap == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1.position, movSpeed * Time.deltaTime);
        }

        if(transform.position == target1.position)
        {
            crap = false;
        }

        if(crap == false)
        {

            transform.Translate(userDir * movSpeed * Time.deltaTime);
        }
	}
}
