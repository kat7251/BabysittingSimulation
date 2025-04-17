using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableGrabDuringNarration : MonoBehaviour, INotificationReceiver
{
    private XRGrabInteractable grabInteractable;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    public void OnNotify(Playable origin, INotification notification, object context)
    {
        if (notification is SignalEmitter signalEmitter && signalEmitter.asset != null)
        {
            string signalName = signalEmitter.asset.name;

            switch (signalName)
            {
                case "DisableGrab":
                    if (grabInteractable != null)
                        grabInteractable.enabled = false;
                    break;
                case "EnableGrab":
                    if (grabInteractable != null)
                        grabInteractable.enabled = true;
                    break;
            }
        }
    }
}
