using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using static UnityEditor.VersionControl.Asset;


public class PointCounter : MonoBehaviour
{
    [SerializeField] private ScoreCounter pointHUD;
    [SerializeField] private PlayableDirector endGameTimeline;

    private AudioSource audiosource;

    public GameObject mainCharacter;

    /*public float animDuration;
    public List<GameObject> states;*/

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

        if (pointHUD.Points >= 4)
        {
            FindAnyObjectByType<GirlAnimationSetter>().SetStateActive("Final");

            TriggerEndGame();
        }
        /*states.Find(state => state.name == name).SetActive(true);
        StartCoroutine(StartAnimDelay());*/
    }

    /*IEnumerator StartAnimDelay()
    {
        yield return new WaitForSeconds(animDuration);
        foreach (GameObject go in states)
        {
            go.SetActive(false);
        }
        states[0].SetActive(true);
    }*/


    private void TriggerEndGame()
    {
        Debug.Log("End Game Timeline Triggered!");

        if (endGameTimeline != null)
        {
            endGameTimeline.Play();
        }
    }
}
