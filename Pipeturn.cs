using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeturn: MonoBehaviour
{
    private float rotationAmount = 90f;

    private void OnMouseDown()
    {
        transform.Rotate(Vector3.forward, rotationAmount);
    }
}