using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    private int _health;
    private int _maxHealth = 100;

    void Awake()
    {
        //Set health to our maximum health value
        _health = _maxHealth;
    }

    public void TakeDamage()
    {
        _health--;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }

    public void RestoreHealth()
    {
        _health++;
    }
    
    public void RestoreHealth(int healing)
    {
        _health += healing;
    }
}  