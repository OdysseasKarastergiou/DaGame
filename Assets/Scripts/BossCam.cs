using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCam : MonoBehaviour {

    public Camera MainCamera;
    public Camera BossCamera;

    public AudioSource audio, audioEnd;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
       
    }

    public void changeBossCamera()
    {
        MainCamera.enabled = false;
        BossCamera.enabled = true;
    }

    public void changeMainCamera()
    {
        MainCamera.enabled = true;
        BossCamera.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        changeBossCamera();
        audio.Play();
        audioEnd.Stop();
    }


}
