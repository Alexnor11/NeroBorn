using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCamera : MonoBehaviour
{
    private Transform camTransform;

    public GameObject directionalLight;
    private Transform lightTransform;

    void Start()
    {
        camTransform = GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        //directionalLight = GameObject.Find("Directional Light");
        
        lightTransform = directionalLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    }

}
