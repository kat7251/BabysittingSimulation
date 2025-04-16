using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class DisableGrabbablesDuringTimeline : MonoBehaviour
{
    public List<XRGrabInteractable> grabbableObjects;
    public PlayableDirector timeline;

    void Update()
    {
        bool isPlaying = timeline.state == PlayState.Playing;
        foreach (var obj in grabbableObjects)
        {
            obj.enabled = !isPlaying;
        }
    }
}
