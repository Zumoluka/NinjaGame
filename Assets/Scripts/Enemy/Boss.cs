using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Enemy
{
    private void Start()
    {
        enemyName = "Boss";
        health = 300;
        damage = 25;
    }

    public override void Attack()
    {
        Debug.Log(enemyName + " realiza un ataque especial con " + damage + " de daño.");
    }
}
