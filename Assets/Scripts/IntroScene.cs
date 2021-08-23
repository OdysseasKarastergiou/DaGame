using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour {


    public GameObject trump;
    private Animator anim;
    private bool talk;
    private bool stopTalk;
    private bool start;

    private bool talk2;
    private bool stopTalk2;



    public AudioSource audio, audio2;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        talk = false;
        stopTalk = false;
        start = true;
        talk2 = false;
        stopTalk2 = false;
        Starting();
 

    }
	
	// Update is called once per frame
	void Update () {

       
        if (talk == true)
        {
            if (!audio.isPlaying)
            {
                audio.Play(); }
        }
        if (stopTalk == true)
        {
            if (audio.isPlaying)
            {
                audio.Stop();
            }
        }

        if (talk2 == true)
        {
            if (!audio2.isPlaying)
            {
                audio2.Play();
            }
        }
        if (stopTalk2 == true)
        {
            if (audio2.isPlaying)
            {
                audio2.Stop();
            }
        }






    }

  
    public void TrumpNoTalk()
    {
        anim.SetTrigger("trumpNoTalk");
        stopTalk = true;
    }

    public void TrumpIsTalk()
    {

        anim.SetTrigger("trumpIsTalk");
        talk = true;

    }

    public void TrumpNoTalk2()
    {
        anim.SetTrigger("trumpNoTalk");
        stopTalk2 = true;


    }

    public void TrumpIsTalk2()
    {
        anim.SetTrigger("trumpIsTalk");
        talk2 = true;
    }

    public void Scene2()
    {
        SceneManager.LoadScene("Intro2");
    }

    public void Starting()
    {
        if (start == true)
        {
            Invoke("TrumpIsTalk", 2.0f);
            Invoke("TrumpNoTalk", 4.0f);
            Invoke("TrumpIsTalk2", 8.5f);
            Invoke("TrumpNoTalk2", 10.0f);
            Invoke("Scene2", 12.0f);
        }
    }





}
