using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour {

   

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        
       
    }

    public void Resume()
    {
       
        Application.LoadLevel("GamePog");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game..");
        Application.Quit();
    }

  
}
