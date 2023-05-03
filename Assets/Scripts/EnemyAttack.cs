using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] int damage = 30;
    // Start is called before the first frame update
    void Start()
    {
        target = FindAnyObjectByType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        target.TakeDamage(damage);
        Debug.Log("Attack Event!");
    }
}
