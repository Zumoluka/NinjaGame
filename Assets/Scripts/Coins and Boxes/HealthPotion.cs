using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int healAmount = 25;
    private HUDManager hudManager;

    private void Start()
    {
        hudManager = FindObjectOfType<HUDManager>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            UsePotion();
        }
    }

    private void UsePotion()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.Heal(healAmount);
                Debug.Log("Used health potion. Healed " + healAmount + " health points.");
                hudManager.SetPotions(hudManager.potions - 1); // Update potion count
                Destroy(gameObject);
            }
        }
    }
}
