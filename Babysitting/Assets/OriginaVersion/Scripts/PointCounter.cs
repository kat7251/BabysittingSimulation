using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    [SerializeField] private ScoreCounter pointHUD;

    // Call this method when an object is destroyed
    public void AddPoint()
    {
        pointHUD.Points += 1;
        Debug.Log("Point added! Total: " + pointHUD.Points);
    }
}
