using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{    
    void Start()
    {
        Character hero = new Character();        
        hero.PrintStatsInfo();

        Character heroine = new Character("Agata");
        heroine.PrintStatsInfo();

        Weapon weapon = new Weapon("Hunting Bow", 105);
    }
}
