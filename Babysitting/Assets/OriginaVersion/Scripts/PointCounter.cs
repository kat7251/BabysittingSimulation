using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class PointCounter : MonoBehaviour
{
    [SerializeField] private ScoreCounter pointHUD;
    [SerializeField] private PlayableDirector endGameTimeline;

    private AudioSource audiosource;

    public GameObject mainCharacter;
    Animator animator;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>();

        animator = mainCharacter.GetComponent<Animator>();
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

        if (pointHUD.Points >= 4)
        {
            animator.Play("Take 005");

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
