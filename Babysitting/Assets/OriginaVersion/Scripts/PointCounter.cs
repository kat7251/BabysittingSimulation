using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class PointCounter : MonoBehaviour
{
    [SerializeField] private ScoreCounter pointHUD;
    [SerializeField] private PlayableDirector endGameTimeline;

    // Call this method when an object is destroyed
    public void AddPoint()
    {
        pointHUD.Points += 1;
        Debug.Log("Point added! Total: " + pointHUD.Points);

        if (pointHUD.Points >= 3)
        {
            TriggerEndGame();
        }
    }

    private void TriggerEndGame()
    {
        Debug.Log("End Game Timeline Triggered!");

        if (endGameTimeline != null)
        {
            endGameTimeline.Play();
        }
    }
}
