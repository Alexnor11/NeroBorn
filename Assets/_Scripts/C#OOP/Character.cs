using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "Not assigned";
    }

    public Character(string name)
    {
        this.name = name;       
    }

    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1}", name, exp);
    }
}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this .name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DBM", name , damage);
    }

    private void Reset()
    {
        this.name = "Not assigned";
        this.damage = 0;
    }
}
