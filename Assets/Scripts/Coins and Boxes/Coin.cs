using Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, ICollectible
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CollectCoin(other.gameObject);
        }
    }


    private void CollectCoin(GameObject player)
    {
        MainNinja playerController = player.GetComponent<MainNinja>();
        if (playerController != null)
        {
            playerController.AddCoins(coinValue);
        }
        Destroy(gameObject);
    }
    public void Collect()
    {
        Debug.Log("Coin collected!");

        Destroy(gameObject);
    }
}
