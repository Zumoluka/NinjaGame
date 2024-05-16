using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI potionText;
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI timeText;

    public int potions = 3;
    private int points = 0;
    private float elapsedTime = 0f;

    private void Start()
    {
        UpdateHUD();
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        UpdateTime();
    }

    public void SetPotions(int amount)
    {
        potions = amount;
        UpdateHUD();
    }

    public void SetPoints(int amount)
    {
        points = amount;
        UpdateHUD();
    }

    private void UpdateHUD()
    {
        potionText.text = "Potions: " + potions;
        pointsText.text = "Points: " + points;
    }

    private void UpdateTime()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timeText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }
}
