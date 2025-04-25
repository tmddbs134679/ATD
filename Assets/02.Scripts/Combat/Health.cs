using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    private int health;

    public event Action OnTakeDamage;
    void Start()
    {
        health = maxHealth;
    }


    void Update()
    {
        
    }


    public void DealDamage(int dmg)
    {
        if (health <= 0) { return; }

        health = Mathf.Max(health - dmg, 0);

        OnTakeDamage?.Invoke();

        Debug.Log(health);
    }
}
