using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addedAge = 1;

    public float pi = 3.14f;
    //public string firstName = "string.Empty";

    private void Start()
    {
        //ComputerAge();

        int characterLevel = 32;
        string firstName = "AlexNor";
        //int nextSkillLevel = GenerateCharacter("Spike", characterLevel);

        //print(nextSkillLevel);
        print(GenerateCharacter(firstName, characterLevel));

        //NewMethod(GenerateCharacter("Faye", characterLevel));
       
        //print($"A string can have variables like {firstName} inserted directly!");
    }

    void ComputerAge()
    {
        print(currentAge + addedAge);
    }

    public string GenerateCharacter(string name, int level)
    {
        //Debug.LogFormat("Character: {0} - Level: {1}" , name, level);
        return name;
    }

    public void NewMethod(int num)
    {
        print(num);
    }
}
