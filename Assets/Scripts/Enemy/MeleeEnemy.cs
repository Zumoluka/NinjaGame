using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    private void Start()
    {
        enemyName = "Enemigo Melee";
        health = 100;
        damage = 10;
    }

    public override void Attack()
    {
        Debug.Log(enemyName + " ataca cuerpo a cuerpo con " + damage + " de daño.");
    }
}
