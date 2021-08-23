using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMachete : MonoBehaviour {


    public GameObject mac;

    public static int movespeed = 5;

    public Vector3 userDirection = Vector3.up;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(userDirection * movespeed * Time.deltaTime);

    }



    
}


