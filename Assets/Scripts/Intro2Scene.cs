using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro2Scene : MonoBehaviour {

    public GameObject trump;
    private Animator anim;
    private bool talk;
    private bool stopTalk;
    private bool start;

    public AudioSource audio;
    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        talk = false;
        stopTalk = false;
        start = true;
        Starting();

    }

    // Update is called once per frame
    void Update () {
        if (talk == true)
        {
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }
        if (stopTalk == true)
        {
            if (audio.isPlaying)
            {
                audio.Stop();
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



    public void Starting()
    {
        if (start == true)
        {
            Invoke("TrumpIsTalk", 4.0f);
            Invoke("TrumpNoTalk", 6.0f);
        }
    }
}
