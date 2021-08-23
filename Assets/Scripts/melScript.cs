using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melScript : MonoBehaviour {

 
    public GameObject mel;
    public Transform target1, target2, target3;
    public GameObject take;
 
 
    public static int movementSpeed = 5;
    public static int movementSpeed2 = 2;
    public bool shit;

    // Use this for initialization
    void Start () {
        take.SetActive(false);
        shit = true; 
    }
	
	// Update is called once per frame
	void Update () {

        if (shit == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1.position, movementSpeed * Time.deltaTime);
            
        }

        if (transform.position == target1.position)
        {
            shit = false;
             
        }

        if(shit == false)
        {
            take.SetActive(true);
            transform.position = Vector3.MoveTowards(transform.position, target2.position, movementSpeed2 * Time.deltaTime);
        }

        Debug.Log(shit);
         
    }

   


}
 
