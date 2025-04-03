using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject orangeObject; // The initially non-interactable object

    private void Start()
    {
        if (orangeObject != null)
        {
            orangeObject.GetComponent<Collider>().enabled = false; // Disable interaction initially
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ResetZone")) // Assuming the basket has the tag "Basket"
        {
            if (orangeObject != null)
            {
                orangeObject.GetComponent<Collider>().enabled = true; // Enable interaction when blue object is destroyed
            }

            Destroy(gameObject); // Destroy the blue object
        }
    }
}
