using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class XActivity : MonoBehaviour
{
    public GameObject  yellowButton, PinkButton, GreenBAllButton, lighjtYellowButton, purpleBallButton, keyButton, bottle;
    public GameObject yellowStar,lightYellow,purpleBall,PinkBall,GreenBall;
    public AudioSource KeySound, bottleSound ,YellowStarSound,purplesound,greenSound,pinkSound,lightyellow= default;
    public AudioClip betterluckNextTime, oops,amazing, Excelent ,cool, Brilliant = null;
    public GameObject[] buttons;
    void Start()
    {
        yellowStar.SetActive(false);
        lightYellow.SetActive(false);
        purpleBall.SetActive(false);
        PinkBall.SetActive(false);
        GreenBall.SetActive(false);
        
    }
    public void Purpleball()
    {
        purpleBall.SetActive(true);
        purpleBallButton.SetActive(false);
        purplesound.PlayOneShot(Excelent);
    }
    public void YellowButton()
    {  
        yellowStar.SetActive(true);
        YellowStarSound.PlayOneShot(amazing);
        yellowButton.SetActive(false);
     
    }
    public void greenBall()
    {
        GreenBall.SetActive(true);
        greenSound.PlayOneShot(cool);
        GreenBAllButton.SetActive(false);
       
    }
    public void pinkBall()
    {
        PinkBall.SetActive(true);
        PinkButton.SetActive(false);
        pinkSound.PlayOneShot(Brilliant);

    }
    public void LighjtYellow()
    {
        lightYellow.SetActive(true);
        lighjtYellowButton.SetActive(false);
        lightyellow.PlayOneShot(amazing);
    }
    public void KeyAudio()
    {
        bottleSound.PlayOneShot(oops);
    }
    public void BottleAudio()
    {
        KeySound.PlayOneShot(betterluckNextTime);
    }
    public void Update()
    {
        /*GameManager.Instance.ActiveButtons("changemanager")*/
    }
}
