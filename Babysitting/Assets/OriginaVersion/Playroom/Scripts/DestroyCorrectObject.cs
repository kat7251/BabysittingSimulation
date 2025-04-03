using UnityEngine;

public class DestroyCorrectObject : MonoBehaviour
{
    public GameObject nextObject; // Assign the next object in the sequence

    private void Start()
    {
        if (nextObject != null)
        {
            nextObject.SetActive(false); // Initially disable the next object
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ResetZone"))
        {
            if (nextObject != null)
            {
                nextObject.SetActive(true); // Enable the next object in sequence
            }

            Destroy(gameObject);
            Debug.Log("Destroyed Object, Next Object Activated");
        }
    }
}
