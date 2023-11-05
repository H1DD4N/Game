using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text currentTime;

    public void GetTime()
    {
        currentTime.text = PlayerPrefs.GetFloat("Time").ToString();
    }

    public void GetName()
    {

    }
   
}
