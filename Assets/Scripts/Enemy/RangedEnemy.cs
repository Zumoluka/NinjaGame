using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : Enemy
{
    private void Start()
    {
        enemyName = "Enemigo a Distancia";
        health = 80;
        damage = 15;
    }

    public override void Attack()
    {
        Debug.Log(enemyName + " ataca a distancia con " + damage + " de daño.");
    }
}
