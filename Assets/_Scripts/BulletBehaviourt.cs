using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviourt : MonoBehaviour
{
    public float onscreenDelay = 3f;

    private void Start()
    {
        Destroy(gameObject, onscreenDelay);
    }
}
