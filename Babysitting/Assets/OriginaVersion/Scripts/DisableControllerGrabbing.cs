using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.XR.Interaction.Toolkit;

/*public class DisableControllerGrabbing : MonoBehaviour, INotificationReceiver
{
    public XRDirectInteractor leftInteractor;
    public XRDirectInteractor rightInteractor;

    public void OnNotify(Playable origin, INotification notification, object context)
    {
        if (notification is SignalEmitter emitter && emitter.asset != null)
        {
            string signalName = emitter.asset.name;

            switch (signalName)
            {
                case "DisableGrab":
                    SetInteractorGrabbing(false);
                    break;
                case "EnableGrab":
                    SetInteractorGrabbing(true);
                    break;
            }
        }
    }

    private void SetInteractorGrabbing(bool enable)
    {
        if (leftInteractor != null)
            leftInteractor.enabled = enable;

        if (rightInteractor != null)
            rightInteractor.enabled = enable;
    }
}*/


public class DisableControllerGrabbing : MonoBehaviour
/*{
    [Header("Assign your XR Direct Interactors here")]
    public XRDirectInteractor leftInteractor;
    public XRDirectInteractor rightInteractor;

    public void DisableGrabbing()
    {
        if (leftInteractor != null)
            leftInteractor.enabled = false;

        if (rightInteractor != null)
            rightInteractor.enabled = false;

        Debug.Log("Grabbing disabled.");
    }

    public void EnableGrabbing()
    {
        if (leftInteractor != null)
            leftInteractor.enabled = true;

        if (rightInteractor != null)
            rightInteractor.enabled = true;

        Debug.Log("Grabbing enabled.");
    }
}

public class DisableRayGrabbingPublic : MonoBehaviour*/
{
    [Header("Direct Interactors")]
    public XRDirectInteractor leftDirectInteractor;
    public XRDirectInteractor rightDirectInteractor;

    [Header("Ray Interactors")]
    public XRRayInteractor leftRayInteractor;
    public XRRayInteractor rightRayInteractor;

    public void DisableGrabbing()
    {
        if (leftDirectInteractor != null) leftDirectInteractor.enabled = false;
        if (rightDirectInteractor != null) rightDirectInteractor.enabled = false;
        if (leftRayInteractor != null) leftRayInteractor.enabled = false;
        if (rightRayInteractor != null) rightRayInteractor.enabled = false;

        Debug.Log("All grabbing/interactions disabled.");
    }

    public void EnableGrabbing()
    {
        if (leftDirectInteractor != null) leftDirectInteractor.enabled = true;
        if (rightDirectInteractor != null) rightDirectInteractor.enabled = true;
        if (leftRayInteractor != null) leftRayInteractor.enabled = true;
        if (rightRayInteractor != null) rightRayInteractor.enabled = true;

        Debug.Log("All grabbing/interactions enabled.");
    }
}

