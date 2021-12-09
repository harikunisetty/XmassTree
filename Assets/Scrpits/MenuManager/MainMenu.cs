using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : Menu<MainMenu>
{
    [Header("Load Current Play Level")]
    [SerializeField] int loadLevelOne = 1;

    [SerializeField] GameObject BgImage;

    public void PlayButton()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoadNextLevel(loadLevelOne);
            BgImage.SetActive(false);
        }
      
    }
}
