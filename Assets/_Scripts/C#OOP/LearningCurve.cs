using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{    
    void Start()
    {
        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1}", hero.name, hero.exp);

        Character heroine = new Character("Agata");
        Debug.LogFormat("Hero: {0} - {1}" , heroine.name, heroine.exp);
    }
}
