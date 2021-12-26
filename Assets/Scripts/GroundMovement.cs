using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public Vector3 Offset;
    private float factor = 1;
    void FixedUpdate()
    {
        Vector3 Mvmnt = factor * Constants.BASE_SPEED * Vector3.forward;
        transform.Translate(Mvmnt);
    }
}