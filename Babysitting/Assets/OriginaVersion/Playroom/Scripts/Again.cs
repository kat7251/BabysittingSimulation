using UnityEngine;

public class Again : MonoBehaviour
{
    public GameObject orangeObject; // The initially non-interactable object
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true; // Prevents the blue object from falling through the ground initially
        }

        if (orangeObject != null)
        {
            orangeObject.GetComponent<Collider>().enabled = false; // Disable interaction initially
        }
    }

    public void PickUp()
    {
        if (rb != null)
        {
            rb.isKinematic = false; // Allow movement
            rb.useGravity = true; // Ensure gravity affects it
        }
    }

    public void Throw(Vector3 force)
    {
        if (rb != null)
        {
            rb.isKinematic = false; // Disable kinematic mode so force can be applied
            rb.useGravity = true; // Enable gravity
            rb.velocity = Vector3.zero; // Reset velocity to ensure consistent throwing
            rb.angularVelocity = Vector3.zero; // Reset angular velocity
            rb.AddForce(force, ForceMode.Impulse); // Apply throw force
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ResetZone")) // Assuming the basket has the tag "Basket"
        {
            Destroy(gameObject); // Destroy the blue object

            if (orangeObject != null)
            {
                orangeObject.GetComponent<Collider>().enabled = true; // Enable interaction when blue object is destroyed
            }

            
        }
    }
}
