using System.Collections;
using System.Collections.Generic;
//using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;

using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class DestroyBlock2 : MonoBehaviour
{
    public GameObject nextObject; // Assign the next object in the sequence

    // Animator animator;


    private void Start()
    {
        //animator = GetComponent<Animator>();


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

            //animator.Play("Attack");

            //BlockCounter.gscore += 1;

            Destroy(gameObject);
            Debug.Log("Destroyed Object, Next Object Script Activated");



        }
    }
}
