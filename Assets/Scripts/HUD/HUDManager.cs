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
    private void OnEnable()
    {
        Enemy.OnEnemyDefeated += UpdateScore;
        MainNinja.OnNinjaJump += ShowJumpMessage;
        MainNinja.OnNinjaAttack += ShowAttackMessage;
        MainNinja.OnNinjaHurt += ShowHurtMessage;
        GameController.OnGameStarted += ShowGameStartMessage;
        GameController.OnLevelCompleted += ShowLevelCompletedMessage;
        GameController.OnGamePaused += ShowPauseMessage;
    }

    private void OnDisable()
    {
        Enemy.OnEnemyDefeated -= UpdateScore;
        MainNinja.OnNinjaJump -= ShowJumpMessage;
        MainNinja.OnNinjaAttack -= ShowAttackMessage;
        MainNinja.OnNinjaHurt -= ShowHurtMessage;
        GameController.OnGameStarted -= ShowGameStartMessage;
        GameController.OnLevelCompleted -= ShowLevelCompletedMessage;
        GameController.OnGamePaused -= ShowPauseMessage;
    }

    private void UpdateScore()
    {
        Debug.Log("Score updated!");
    }

    private void ShowJumpMessage()
    {
        Debug.Log("Ninja jumped!");
    }

    private void ShowAttackMessage()
    {
        Debug.Log("Ninja attacked!");
    }

    private void ShowHurtMessage()
    {
        Debug.Log("Ninja hurt!");
    }

    private void ShowGameStartMessage()
    {
        Debug.Log("Game started!");
    }

    private void ShowLevelCompletedMessage()
    {
        Debug.Log("Level completed!");
    }

    private void ShowPauseMessage()
    {
        Debug.Log("Game paused!");
    }
}
