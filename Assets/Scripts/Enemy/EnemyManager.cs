using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //GameManager
    public Enemy[] enemies;

    private void Start()
    {
        // Inicializar enemigos
        enemies = new Enemy[]
        {
            new MeleeEnemy(),
            new RangedEnemy(),
            new Boss()
        };

        foreach (var enemy in enemies)
        {
            enemy.Attack();
        }
    }
}
