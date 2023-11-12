using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PressOneTime : MonoBehaviour
{
    public Button myButton;
    private bool buttonPressed = false;

    void Start()
    {
        // F�ge eine Listener-Funktion f�r den Button hinzu
        myButton.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (!buttonPressed)
        {
            // F�hre den Code aus, der beim Dr�cken des Buttons ausgef�hrt werden soll
            Debug.Log("Button wurde gedr�ckt!");

            // Deaktiviere den Button, um sicherzustellen, dass er nicht erneut gedr�ckt werden kann
            myButton.interactable = false;

            // Setze die Variable, um zu verhindern, dass der Button erneut gedr�ckt wird
            buttonPressed = true;
        }
    }

    // Optional: Setze den Button zur�ck, wenn n�tig
    public void ResetButtonState()
    {
        myButton.interactable = true;
        buttonPressed = false;
    }
}
