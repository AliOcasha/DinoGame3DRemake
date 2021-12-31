using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    /*Moving the Ground Tiles endlessly forward.
    By Adding a Factor infront of the Mvmnt Vector the Speed can be acclerated.
    This Factor has to be the same in the Obstacle Movement and Border Movement
    */
    void FixedUpdate()
    {
        Vector3 Mvmnt = Constants.BASE_SPEED * Vector3.forward;
        transform.Translate(Mvmnt);
    }
}