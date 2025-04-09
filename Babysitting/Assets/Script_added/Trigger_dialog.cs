using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogTrigger : MonoBehaviour
{
    // Reference to the dialog UI (you can link this to your dialog UI in the Unity Inspector)
    public GameObject dialogUI;

    private void Start()
    {
        // Ensure the dialog is hidden at the beginning
        if (dialogUI != null)
        {
            dialogUI.SetActive(false); // Hide the dialog initially
        }
    }

    // Trigger event when the player enters the collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player (or a specific tag) enters the trigger area
        if (other.CompareTag("Player"))
        {
            // Show the dialog
            ShowDialog();
        }
    }

    // Function to show the dialog UI
    private void ShowDialog()
    {
        if (dialogUI != null)
        {
            dialogUI.SetActive(true); // Show the dialog UI
        }
    }

    // Optional: Hide dialog when the player leaves the trigger area
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HideDialog();
        }
    }

    // Function to hide the dialog UI
    private void HideDialog()
    {
        if (dialogUI != null)
        {
            dialogUI.SetActive(false); // Hide the dialog UI
        }
    }
}

