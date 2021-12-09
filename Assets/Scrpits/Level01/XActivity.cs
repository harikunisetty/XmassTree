using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XActivity : MonoBehaviour
{
    [Header("UIScaler")]
    [SerializeField] float resoX;
    [SerializeField] float resoY;
    private CanvasScaler can;

    public GameObject  yellowButton, PinkButton, GreenBAllButton, lighjtYellowButton, purpleBallButton, keyButton, bottle;
    public GameObject yellowStar,lightYellow,purpleBall,PinkBall,GreenBall;
    public AudioSource KeySound, bottleSound = default;
    public AudioClip betterluckNextTime, oops = null;
    /*public GameObject[] buttons;*/

  

    void Start()
    {
        can = GetComponent<CanvasScaler>();
        SetInfo();
        yellowStar.SetActive(false);
        lightYellow.SetActive(false);
        purpleBall.SetActive(false);
        PinkBall.SetActive(false);
        GreenBall.SetActive(false);
    }
    public void SetInfo()
    {
        resoX = (float)Screen.currentResolution.width;
        resoY = (float)Screen.currentResolution.height;
        can.referenceResolution = new Vector2(resoX, resoY);
    }
    public void Purpleball()
    {
        purpleBallButton.SetActive(false);
        purpleBall.SetActive(true);
    }
    public void YellowButton()
    {
        yellowStar.SetActive(true);
        yellowButton.SetActive(false);

    }
    public void greenBall()
    {
        GreenBall.SetActive(true);
        GreenBAllButton.SetActive(false);
    }
    public void pinkBall()
    {
        PinkBall.SetActive(true);
        PinkButton.SetActive(false);
    }
    public void LightYellow()
    {
        lightYellow.SetActive(true);
        lighjtYellowButton.SetActive(false);
    }
    public void KeyAudio()
    {
        bottleSound.PlayOneShot(oops);
    }
    public void BottleAudio()
    {
        KeySound.PlayOneShot(betterluckNextTime);
    }
   /* public void Update()
    {
        GameManager.Instance.ActiveButtons("changemanager")
     }*/

    /* public void Update()
     {
         if (buttons.Length != 0)
         {
             for (int j = buttons.Length; j >= 0; j++)
             {
                 buttons[0].SetActive(false);
                 buttons[1].SetActive(false);
                 buttons[2].SetActive(false);
                 buttons[3].SetActive(false);
                 buttons[4].SetActive(false);
             }
         }    
         if (buttons.Length == 0)
         {
             // you should mentions scene name here .......!
             GameManager.Instance.LoadNextLevel(loadLevelTwo);
         }
     }*/
}
