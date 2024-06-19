using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    public static event Action OnGameStarted;
    public static event Action OnLevelCompleted;
    public static event Action OnGamePaused;

    private void Start()
    {
        // Simular el inicio del juego
        Debug.Log("Game started!");
        OnGameStarted?.Invoke();
    }

    public void CompleteLevel()
    {
        // Simular la finalización de un nivel
        Debug.Log("Level completed!");
        OnLevelCompleted?.Invoke();
    }

    public void PauseGame()
    {
        // Simular la pausa del juego
        Debug.Log("Game paused!");
        OnGamePaused?.Invoke();
    }
}
