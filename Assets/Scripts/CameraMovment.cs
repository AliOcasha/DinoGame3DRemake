using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public Transform Target;

    private Vector3 Offset = new Vector3(0f, 1.05f, -4.85f);
    private Quaternion Rotation = Quaternion.Euler(0f,0f,0f);
    void Start()
    {
        transform.position = Offset;
        transform.rotation = Rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + Offset; 
    }
}
