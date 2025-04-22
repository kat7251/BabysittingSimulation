using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlAnimationSetter : MonoBehaviour
{
    public List<GameObject> states;
    public float animDuration;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in states)
        {
            go.SetActive(false);
        }
        states[0].SetActive(true);
    }
    public void SetStateActive(string name)
    {
        foreach (GameObject go in states)
        {
            go.SetActive(false);
        }
        states.Find(state => state.name == name).SetActive(true);
        StartCoroutine(StartAnimDelay());
    }

    IEnumerator StartAnimDelay()
    {
        yield return new WaitForSeconds(animDuration);
        foreach (GameObject go in states)
        {
            go.SetActive(false);
        }
        states[0].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
