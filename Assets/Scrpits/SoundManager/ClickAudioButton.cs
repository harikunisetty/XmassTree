using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickAudioButton : MonoBehaviour
{
    public AudioSource myAudio;
    public AudioClip file1;
    public  void clickSound()
    {
        myAudio.PlayOneShot(file1);
    }
}
