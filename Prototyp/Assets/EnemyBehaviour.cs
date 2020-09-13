using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int health;
    
    public GameObject bullet;

     
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <=0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
