using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : MonoBehaviour
{

        [SerializeField] float speedBoostAmount; // Anpassbarer Geschwindigkeits-Boost-Faktor 
        [SerializeField] GameObject WinItem;

        private Renderer objectRenderer;
        private void Start()
        {
        objectRenderer = GetComponent<Renderer>();
        }
    private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                PlayerController playerMovement = other.GetComponent<PlayerController>();
                if (playerMovement != null)
                {
                StartCoroutine(ActivateSpeedBoost(playerMovement));
                Hide();
                }
                
            }
        }

    IEnumerator ActivateSpeedBoost(PlayerController playerMovement)
    {
        
        playerMovement.IncreaseSpeed(speedBoostAmount);
        yield return new WaitForSeconds(3);
        playerMovement.ResetSpeed();

        Debug.Log("Speed Boost expired");
    }

    private void Hide()
    {
        // Setze die 'enabled'-Eigenschaft der Renderer-Komponente auf false
        if (objectRenderer != null)
        {
            objectRenderer.enabled = false;
        }
    }
}
