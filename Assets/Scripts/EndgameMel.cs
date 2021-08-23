using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndgameMel : MonoBehaviour {


    public GameObject mel;
    public GameObject trump;

    public static int movSpeed = 2;
    public Vector3 userDir = Vector3.up;

 
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        Invoke("Go", 7.2f);
        Invoke("GG", 17.0f);
	}

    public void Go()
    {
        transform.Translate(userDir * movSpeed * Time.deltaTime);
    }

    public void GG()
    {
        SceneManager.LoadScene("Menu");
    }


}
