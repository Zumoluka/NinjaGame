using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainNinja : MonoBehaviour
{

    private int health;
    private InmortalityBuff immortalityBuff;
    private float speed;
    private int coinCount = 0;
    private int damage = 25;
    private HUDManager hudManager;
    private void Start()
    {
        immortalityBuff = new InmortalityBuff(10f);
        hudManager = FindObjectOfType<HUDManager>();
    }

    public void GetImmortalityBuff()
    {
        if (!immortalityBuff.IsActive())
        {
            immortalityBuff.ActivateBuff();
            StartCoroutine(immortalityBuff.StartBuffDurationCoroutine());
            StartCoroutine(immortalityBuff.StartBuffDurationCoroutine());
        }
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

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
        SceneManager.LoadScene(1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestructibleCube destructible = collision.gameObject.GetComponent<DestructibleCube>();
        if (destructible != null)
        {
            destructible.TakeDamage(damage);
        }
    }
    public void AddCoins(int amount)
    {
        coinCount += amount;
        hudManager.SetPoints(coinCount);
        Debug.Log("Coins: " + coinCount);
    }
}
