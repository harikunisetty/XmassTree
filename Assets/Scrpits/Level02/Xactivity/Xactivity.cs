using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xactivity : MonoBehaviour
{
    public GameObject greenStarButton, orangeBallButton,SkyBlueBallButton, lightPinkBallButton, PurplestarButton;
    public GameObject greenStar, orangeBall, SkyBlueBall, lightOrangeBall,Purplestar;
    private void Start()
    {
        greenStar.SetActive(false);
        orangeBall.SetActive(false);
        SkyBlueBall.SetActive(false);
        lightOrangeBall.SetActive(false);
        Purplestar.SetActive(false);
    }
    public void GreenStar()
    {
        greenStarButton.SetActive(false);
        greenStar.SetActive(true);
    }
    public void OrangeBall()
    {
        orangeBallButton.SetActive(false);
        orangeBall.SetActive(true);

    }
    public void PurpleStar()
    {
        PurplestarButton.SetActive(false);
        Purplestar.SetActive(true);
    }
    public void skyBlueBall()
    {
        SkyBlueBallButton.SetActive(false);
        SkyBlueBall.SetActive(true);
    }
    public void LightOrangeBall()
    {
        lightPinkBallButton.SetActive(false);
        lightOrangeBall.SetActive(true);
    }
   
}
