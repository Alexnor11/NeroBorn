using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    private float vInput;
    private float hIutput;

    private void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hIutput = Input.GetAxis("Horizontal") * rotateSpeed;

        this.transform.Translate(Vector3.forward * vInput *  Time.deltaTime);
        this.transform.Rotate(Vector3.up * hIutput  * Time.deltaTime);
    }
}
