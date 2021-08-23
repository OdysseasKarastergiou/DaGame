using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlowMo : MonoBehaviour {

    public float slowFac = 0.5f;
    public float slowLen = 3.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        Time.timeScale += (1f / slowLen)*Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
	}

    public void slowMotion()
    {
        Time.timeScale = slowFac;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }

   
}
