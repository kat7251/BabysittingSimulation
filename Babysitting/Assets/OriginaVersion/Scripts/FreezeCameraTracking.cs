using UnityEngine;

public class FreezeCameraTracking : MonoBehaviour
{
    public bool freezeTracking = false;
    private Vector3 frozenPos;
    private Quaternion frozenRot;

    void LateUpdate()
    {
        if (freezeTracking)
        {
            transform.localPosition = frozenPos;
            transform.localRotation = frozenRot;
        }
    }

    public void Freeze()
    {
        frozenPos = transform.localPosition;
        frozenRot = transform.localRotation;
        freezeTracking = true;
    }

    public void Unfreeze()
    {
        freezeTracking = false;
    }
}
