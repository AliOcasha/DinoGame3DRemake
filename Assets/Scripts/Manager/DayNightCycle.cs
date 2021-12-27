using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Constants.DAY_SPEED*Vector3.right); 
    }
}
