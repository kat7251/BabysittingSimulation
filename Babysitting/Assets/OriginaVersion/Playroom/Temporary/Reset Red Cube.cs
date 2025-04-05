using UnityEngine;

public class ObjectReset : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    void Start()
    {
        // Store the original position and rotation at the start
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    public void ResetObject()
    {
        // Reset position and rotation
        transform.position = originalPosition;
        transform.rotation = originalRotation;

        // If you need to reset velocity (for Rigidbody objects)
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ResetZone"))
        {
            ResetObject();
        }
    }

}
