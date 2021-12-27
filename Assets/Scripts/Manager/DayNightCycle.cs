using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    /*Rotating the Directinal Light on the X-Axis lets you create a Day Night Cycle */
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Constants.DAY_SPEED*Vector3.right); 
    }
}
