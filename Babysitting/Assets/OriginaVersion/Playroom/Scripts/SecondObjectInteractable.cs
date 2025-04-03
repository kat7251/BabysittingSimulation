using UnityEngine;

public class SecondObjectInteractable : MonoBehaviour
{
    public GameObject interactableObject; // Assign the object that should become interactable

    private void OnCollisionEnter(Collision collision)
    {
        if (interactableObject != null)
        {
            interactableObject.GetComponent<Collider>().enabled = true; // Enable interaction
        }

        Destroy(gameObject); // Destroy this object when it collides with another object
    }
}