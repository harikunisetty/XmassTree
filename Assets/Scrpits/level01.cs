using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level01 : MonoBehaviour
{
    public GameObject xbutten01, butten02, butten03, butten04, butten05, butten06;
    public AudioSource myaudio1, myaudio2, myaudio3 = default;
    public AudioClip file1, file2, file3 = null;

    public void butten01()
    {
        xbutten01.SetActive(false);
    }
    public void xbutten02()
    {
        butten02.SetActive(false);
    }
    public void xbutten03()
    {
        butten03.SetActive(false);
    }
    public void xbutten04()
    {
        butten04.SetActive(false);
    }
    public void xbutten05()
    {
        butten05.SetActive(false);
    }
    public void tryagain()
    {
       
        myaudio3.PlayOneShot(file3);
    }
    public void tryagain1()
    {
       
        myaudio1.PlayOneShot(file1);
    }
    public void tryagain2()
    {
       
        myaudio2.PlayOneShot(file2);
    }
}
