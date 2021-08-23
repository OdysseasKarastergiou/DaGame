using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform TrumpPlayer;
    public float camDist = 30.0f;




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   

    private void FixedUpdate()
    {
        transform.position = new Vector3(TrumpPlayer.position.x, TrumpPlayer.position.y, transform.position.z); //h kamera akolouthaei symfwna me thn thesi tou paikth
       
    }

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height/5) / camDist);
    }

   
}
