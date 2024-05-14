using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainNinja : MonoBehaviour
{

    private int health;
    private InmortalityBuff immortalityBuff;

    private void Start()
    {
        immortalityBuff = new InmortalityBuff(10f); 
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

    private float speed;
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
}
