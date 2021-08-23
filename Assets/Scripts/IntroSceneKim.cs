using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSceneKim : MonoBehaviour {

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

        Invoke("KimIsTalk", 5.0f);
        Invoke("KimNoTalk", 7.0f);


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




}


