using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    private int _health, _maxHealth = 100;

    private void Awake()
    {
        //Set health to our maximum health value
        _health = _maxHealth;
    }

    /// <summary>
    ///  Make the player take one damage. This function can be overloaded with a int for the damage value.
    /// </summary>
    /// <param name="TakeDamage">Makes the player take one damage.</param>
    /// <returns></returns>
    public void TakeDamage()
    {
        _health--;
    }

    /// <summary>
    ///  Make the player take a given value of damage.
    /// </summary>
    /// <param name="TakeDamage">Makes the player take a given amount of damage.</param>
    /// <returns></returns>
    public void TakeDamage(int damage)
    {
        _health -= damage;
    }

    /// <summary>
    ///  Make the player restore one health. This function can be overloaded with a int for the heal value.
    /// </summary>
    /// <param name="RestoreHealth">Makes the player restore one health.</param>
    /// <returns></returns>
    public void RestoreHealth()
    {
        _health++;
    }

    /// <summary>
    ///  Make the player restore a given value of health.
    /// </summary>
    /// <param name="RestoreHealth">Makes the player restore a given amount of health.</param>
    /// <returns></returns>
    public void RestoreHealth(int healing)
    {
        _health += healing;
    }
}