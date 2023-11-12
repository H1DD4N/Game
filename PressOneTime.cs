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
        // Füge eine Listener-Funktion für den Button hinzu
        myButton.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (!buttonPressed)
        {
            // Führe den Code aus, der beim Drücken des Buttons ausgeführt werden soll
            Debug.Log("Button wurde gedrückt!");

            // Deaktiviere den Button, um sicherzustellen, dass er nicht erneut gedrückt werden kann
            myButton.interactable = false;

            // Setze die Variable, um zu verhindern, dass der Button erneut gedrückt wird
            buttonPressed = true;
        }
    }

    // Optional: Setze den Button zurück, wenn nötig
    public void ResetButtonState()
    {
        myButton.interactable = true;
        buttonPressed = false;
    }
}
