using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CollectCoin(other.gameObject);
        }
    }

    // Método para recoger la moneda
    private void CollectCoin(GameObject player)
    {
        MainNinja playerController = player.GetComponent<MainNinja>();
        if (playerController != null)
        {
            playerController.AddCoins(coinValue);
        }
        Destroy(gameObject);
    }
}
