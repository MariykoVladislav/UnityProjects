using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObstacle : MonoBehaviour
{
    public float rotationSpeed = 0f;
    public bool rotationY = false;
    public bool rotationX = false;
    public bool rotationZ = false;

    void Update()
    {
        if (rotationY)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        if (rotationX)
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        if (rotationZ)
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }
    }
}
