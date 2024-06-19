using Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleCube : MonoBehaviour, IDestroyable
{
    public GameObject coinPrefab;
    public int health = 3;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        DropCoin();
        Destroy(gameObject);
    }
    private void DropCoin()
    {
        Instantiate(coinPrefab, transform.position, Quaternion.identity);
    }
    public void Destroy()
    {
        Debug.Log("Barrel destroyed!");

        Destroy(gameObject);
    }
}
