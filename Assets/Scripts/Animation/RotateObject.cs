using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float xSpeed = 5f, ySpeed = 0f, zSpeed = 0f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpeed, ySpeed, zSpeed);
    }
}
