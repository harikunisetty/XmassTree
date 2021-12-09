using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickAudioButton : MonoBehaviour
{
    public AudioSource myAudio;
    public AudioClip file1;
    public AudioClip file2;


    public void Hower()
    {
        myAudio.PlayOneShot(file2);
    }
    public  void clickSound()
    {
        myAudio.PlayOneShot(file1);
    }
}
