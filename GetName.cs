using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetName : MonoBehaviour
{
    public TMP_InputField inputField;
    
    public void SaveData()
    {
        PlayerPrefs.SetString("Name", inputField.text);
    }
}
