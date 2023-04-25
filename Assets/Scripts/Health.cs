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

    private void TakeDamage()
    {
        _health--;
    }

    private void RestoreHealth()
    {
        _health++;
    }
}  