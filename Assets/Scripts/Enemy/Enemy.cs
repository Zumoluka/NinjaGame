using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public string enemyName;
    public int health;
    public int damage;


    public abstract void Attack();
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        Debug.Log(enemyName + " ha muerto.");
        Destroy(gameObject);
    }
}
