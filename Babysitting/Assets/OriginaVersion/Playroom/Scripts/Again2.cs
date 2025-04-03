using UnityEngine;

public class Again2 : MonoBehaviour
{
    public GameObject orangeObject; // The initially non-interactable object
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true; // Prevents the blue object from falling initially
            rb.useGravity = false; // Disable gravity until it's picked up
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
            rb.useGravity = true; // Enable gravity
        }
    }

    public void Throw(Vector3 force)
    {
        if (rb != null)
        {
            rb.isKinematic = false; // Ensure object is not kinematic
            rb.useGravity = true; // Make sure gravity is applied
            rb.velocity = Vector3.zero; // Reset velocity
            rb.angularVelocity = Vector3.zero; // Reset angular velocity
            rb.AddForce(force, ForceMode.Impulse); // Apply throw force
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basket")) // Assuming the basket has the tag "Basket"
        {
            if (orangeObject != null)
            {
                orangeObject.GetComponent<Collider>().enabled = true; // Enable interaction when blue object is destroyed
            }

            Destroy(gameObject); // Destroy the blue object
        }
    }
}
