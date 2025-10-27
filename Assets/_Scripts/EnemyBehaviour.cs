using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            print("Player detected ­ attack!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if( other.name == "Player")
        {
            print("Player out of range, resume patrol");
        }
    }
}
