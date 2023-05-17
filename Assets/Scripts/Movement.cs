using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float sideSpeed;
    void Update()
    {
        float horizontalSpeed = Input.GetAxis("Horizontal") * sideSpeed * Time.deltaTime; //get horizontal input
        transform.Translate(horizontalSpeed, 0f, forwardSpeed * Time.deltaTime); //x,y,z speed
    }
}
