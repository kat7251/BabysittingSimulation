using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class PointCounter : MonoBehaviour
{
    [SerializeField] private ScoreCounter pointHUD;
    [SerializeField] private PlayableDirector endGameTimeline;

    private AudioSource audiosource;


    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Call this method when an object is destroyed
    public void AddPoint()
    {
        pointHUD.Points += 1;
        Debug.Log("Point added! Total: " + pointHUD.Points);

        if (audiosource != null && audiosource.clip != null)
        {
            audiosource.PlayOneShot(audiosource.clip);
        }

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
