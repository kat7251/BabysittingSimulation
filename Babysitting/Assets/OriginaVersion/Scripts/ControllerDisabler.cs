using UnityEngine;

public class ControllerDisabler : MonoBehaviour
{
    public MonoBehaviour[] scriptsToDisable;

    public void DisableControls()
    {
        foreach (var script in scriptsToDisable)
            script.enabled = false;
    }

    public void EnableControls()
    {
        foreach (var script in scriptsToDisable)
            script.enabled = true;
    }


}
