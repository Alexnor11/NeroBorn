using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{    
    void Start()
    {
        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1}", hero.name, hero.exp);
    }
}
