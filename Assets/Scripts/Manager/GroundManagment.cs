using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManagment : MonoBehaviour
{
    /* Through switching between initial position and current position and
       calculating the distants from the player the illusion of a endless Plane is created
    */
    public List<Transform> Grounds;
    private Vector3 InitialPos1,InitialPos2;
    private float Scale;
    void Start()
    {
        InitialPos1 = Grounds[0].transform.position;
        InitialPos2 = Grounds[1].transform.position;
        Scale = Grounds[0].transform.localScale.z;
    }

    void FixedUpdate()
    {
        Vector3 CurrentPos1 = Grounds[0].transform.position;
        Vector3 CurrentPos2 = Grounds[1].transform.position;
        Vector3 Diff1 = InitialPos1 - CurrentPos1;
        Vector3 Diff2 = InitialPos2 - CurrentPos2;

        if(Diff1.z >= 10*Scale)
        {
            Grounds[0].transform.position = InitialPos2;
        }
        if(Diff2.z >= 20*Scale)
        {
            Grounds[1].transform.position = InitialPos2;
        }

    }
}
