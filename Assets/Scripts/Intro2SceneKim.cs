using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro2SceneKim : MonoBehaviour
{

    public GameObject kim;
    private Animator anim;
    private bool talkKim;
    private bool stopTalkKim;


    public AudioSource audio;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        talkKim = false;
        stopTalkKim = false;
        Invoke("GameTime", 12.2f);


    }

    // Update is called once per frame
    void Update()
    {


        if (talkKim == true)
        {
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }
        if (stopTalkKim == true)
        {
            if (audio.isPlaying)
            {
                audio.Stop();
            }
        }

        Invoke("KimIsTalk", 7.0f);
        Invoke("KimNoTalk", 9.0f);


    }


    public void KimNoTalk()
    {
        anim.SetTrigger("kimNoTalk");
        stopTalkKim = true;
    }

    public void KimIsTalk()
    {
        anim.SetTrigger("kimIsTalk");
        talkKim = true;
    }

    public void GameTime()
    {
        SceneManager.LoadScene("Menu");
    }




}


