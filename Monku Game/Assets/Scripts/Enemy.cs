using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    
    public int health = 100;
    public int damage = 1;
    public GameObject deathEffect;
    public GameObject impactEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);    
    }

    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {   
            GameControlScript.health -= 1;
            SoundManagerScript.PlaySound ("enemyDeath");
        }       
    }
}   
