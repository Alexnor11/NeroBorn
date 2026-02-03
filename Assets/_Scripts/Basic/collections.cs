using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collections : MonoBehaviour
{
    //public bool hasDungeonKey = true;
    //public int currentGold = 35;

    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "Relic Stone";
    public int playerLives = 3;

    private void Start()
    {
        while(playerLives > 0)
        {
            Debug.Log("Stoll alive!");
            playerLives--;
        }

        Debug.Log("Player KO`d...");

        
        //OpenTreasureChamber();
        
        List<string> questPartyMembers = new List<string>()
    {
        "Grim the Barbarian", "Merlin the Wise", "Sreling the Knight"
    };

        //Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        questPartyMembers.Add("Craven the Necromancer");

        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        for (int i = 0 ; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);
            
            if (questPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you`re here Marlin!");
            }
        }

        foreach (string partyMember in questPartyMembers)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        }

        // Словари

        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5 },
            {"Antidot", 7 },
            {"Aspirin", 1 }
        };

        Debug.LogFormat("Items: {0}", itemInventory.Count);

        itemInventory.Add("Throwing Knife", 3);
        itemInventory["Bandage"] = 5;

        Debug.LogFormat("Items: {0}", itemInventory.Count);

        foreach(KeyValuePair<string, int> kvp in itemInventory)
        {
            Debug.LogFormat("Items: {0} - {1}g", kvp.Key, kvp.Value);
        }
    }

    public void OpenTreasureChamber()
    {
        if (pureOfHeart && rareItem == "Relic Stone")
        {
            if (!hasSecretIncantation)
            {
                print("You have spirit, but not the knowlega.");
            }
            else
            {
                print("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            print("Come back when you have what it takes.");
        }
    }    
}
