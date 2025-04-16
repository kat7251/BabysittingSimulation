using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DestroyBlock2 : MonoBehaviour
{
    public GameObject nextObject; // Assign the next object in the sequence

    public AudioSource audioSource; // Reference to AudioSource

    public GameObject mainCharacter;
    Animator animator;

    int pointTotal = 1;

    public GameObject pointcounter;

    public void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();

        animator = mainCharacter.GetComponent<Animator>();

        if (nextObject != null)
        {
            nextObject.GetComponent<DestroyCorrectObject>().enabled = false; // Disable the script instead of the object
        }
    }

    [SerializeField] private PointCounter pointCounter;

    public void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
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
/*
            if (pointTotal <= 3)
            {
                animator.Play("Take 002");
                Debug.Log("Play 002 animation");
            }

            if (pointTotal >= 4)
            {
                animator.Play("Take 005");
                Debug.Log("Play 005 animation");
            }
*/
           
            //pointTotal = pointTotal + 1;
           
            animator.Play("Take 002");

            // Destroy the object immediately after playing the sound
            Destroy(gameObject);

            Debug.Log("Destroyed Object, Next Object Script Activated");
        }


    }

    /*private void PlayAnimation()
    {
        //if (animator == null) return;

        if (pointTotal <= 3)
        {
            animator.Play("Take 002");
            Debug.Log("Play 002 animation");
        }
       /* else
        {
            animator.Play("Take 005");
            Debug.Log("Play 005 animation");
        }*/
    }


