using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    /*Moving the Obstacles endlessly forward, until they pass a given distance of the player and get deleted.
    By Adding a Factor infront of the Mvmnt Vector the Speed can be acclerated.
    This Factor has to be the same in the Ground Movement and Border Movement
    */
    private GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate()
    {
        Vector3 Mvmnt = Constants.BASE_SPEED * Vector3.forward;
        float Diff = Mathf.Abs(Player.transform.position.z - transform.position.z);
        transform.Translate(Mvmnt);
        if (Diff > Constants.OBSTACLE_RADIUS)
        {
            Destroy(gameObject);
        }
    }
}
