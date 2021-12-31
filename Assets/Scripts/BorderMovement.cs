using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderMovement : MonoBehaviour
{
    /*Moving the Ground Tiles endlessly forward.
    By Adding a Factor infront of the Mvmnt Vector the Speed can be acclerated.
    This Factor has to be the same in the Obstacle Movement and Ground Movement
    because this is a Blender Model the movment has to be defined on the x axis.
    */
    void FixedUpdate()
    {
        Vector3 Mvmnt = Constants.BASE_SPEED * Vector3.left;
        transform.Translate(Mvmnt);
    }
}
