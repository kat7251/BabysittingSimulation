using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private Text pointText;
    [SerializeField] private Slider pointBar; // 👈 Add reference to the slider

    [SerializeField] private int maxPoints = 100; // Max value for the bar

    private int points = 0;

    private void Awake()
    {
        pointBar.maxValue = maxPoints;
        UpdateHUD();
    }

    public int Points
    {
        get => points;
        set
        {
            points = Mathf.Clamp(value, 0, maxPoints);
            UpdateHUD();
        }
    }

    private void UpdateHUD()
    {
        pointText.text = points.ToString();
        pointBar.value = points; // Update slider bar fill
    }
}
