using UnityEngine;

public class DisableScript : MonoBehaviour
{
    public GameObject nextObject; // Assign the next object in the sequence

    private void Start()
    {
        if (nextObject != null)
        {
            nextObject.GetComponent<DestroyCorrectObject>().enabled = false; // Disable the script instead of the object
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ResetZone"))
        {
            if (nextObject != null)
            {
                nextObject.GetComponent<DestroyCorrectObject>().enabled = true; // Enable the script on the next object
            }

            Destroy(gameObject);
            Debug.Log("Destroyed Object, Next Object Script Activated");
        }
    }
}
