using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] float timer, startTimer,stopTime;
    [SerializeField] GameObject buttonBg;
    void Start()
    {
        timer = startTimer;
        buttonBg.SetActive(false);
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            timer = stopTime;
            buttonBg.SetActive(true);
        }
    }
}
