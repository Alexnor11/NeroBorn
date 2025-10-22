using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearmingSwitch : MonoBehaviour
{
    public string characterAction = "Attack";
    public int diceRoll = 7;


    private void Start()
    {
        //switch(characterAction)
        //{
        //    case "Heal":
        //        print("Potion sent");
        //        break;
        //    case "Attack":
        //        print("To arms!");
        //        break;
        //    default:
        //        print("Shields up.");
        //        break;
        //}

        switch (diceRoll)
        {
            case 7:
            case 15:
                print("Mediocre damage. not bad.");
                break;
            case 20:
                print("Critical hit, the creature goes down!");
                break;
            default:
                print("You completely missed and fell on you face.");
                    break;
        }
    }
}
