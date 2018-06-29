using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public int AttackDamage;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        EnemyStats EnemyStats = other.gameObject.GetComponent<EnemyStats>();
        if (EnemyStats != null)

        {
            EnemyStats.UpdateHealth(AttackDamage);
        }
    }
}
       
