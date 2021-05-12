using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController
{
    private int health;
    private int healthMax;

    public HealthController(int healthMax)
    {
        this.health = healthMax;
        health = healthMax;
    }

    public int GetHealth()
    {
        return health;
    }
    public float GetHealthPrecent()
    {
        return health / healthMax;
    }
   public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) health = 0;
    }

    public void Heal(int HealAmount)
    {
        health += HealAmount;
        if (health > healthMax) health = healthMax;
    }
}
