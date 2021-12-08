using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<GameObject> buttonList = new List<GameObject>();

    public void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        else
        {
            Instance=this;
        }
    }

    [System.Obsolete]
    public void ActiveButtons()
    {
        if (buttonList.Count != 0)
        {
            for(int i = 0; i < buttonList.Count; i++)
            {
                SceneManager.LoadScene("nextScene");
            }
        }
    }
    private void OnMouseDown()
    {
        
    }
}
