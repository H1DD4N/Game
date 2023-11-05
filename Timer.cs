using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public int startMinutes;
    public Text currentTimeText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60;   
    }

    // Update is called once per frame
    void Update()
    {
        
        
        currentTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        SaveTime();
        currentTimeText.text = String.Format("{0:00}:{1:00}", minutes, seconds);


    }

    public void SaveTime()
    {
        PlayerPrefs.SetFloat("Time", currentTime);
    }

  
}
