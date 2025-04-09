using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DestroyBlock2 : MonoBehaviour
{
    public GameObject nextObject; // Assign the next object in the sequence

    private AudioSource audioSource; // Reference to AudioSource

    private void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();

        if (nextObject != null)
        {
            nextObject.GetComponent<DestroyCorrectObject>().enabled = false; // Disable the script instead of the object
        }
    }

    [SerializeField] private PointCounter pointCounter;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ResetZone"))
        {
            if (nextObject != null)
            {
                nextObject.GetComponent<DestroyCorrectObject>().enabled = true; // Enable the script on the next object
            }

            if (pointCounter != null)
            {
                pointCounter.AddPoint();
            }

            // Play the sound effect
            if (audioSource != null && audioSource.clip != null)
            {
                //audioSource.Play(); // Play sound without waiting for it to finish
                audioSource.PlayOneShot(audioSource.clip);  // Alternative to Play()
            }

            // Destroy the object immediately after playing the sound
            Destroy(gameObject);

            Debug.Log("Destroyed Object, Next Object Script Activated");
        }
    }
}
