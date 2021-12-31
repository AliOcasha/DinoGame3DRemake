using UnityEngine;

public class BirdMovement : MonoBehaviour
{
 /*Moving the Obstacles endlessly forward, until they pass a given distance of the player and get deleted.
    By Adding a Factor infront of the Mvmnt Vector the Speed can be acclerated.
    */
    private GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        transform.rotation = Quaternion.Euler(0f,0f,90f);
    }
    void FixedUpdate()
    {
        Vector3 Mvmnt = Constants.BASE_SPEED * Vector3.forward;
        float Diff = Mathf.Abs(Player.transform.position.z - transform.position.z);
        transform.Translate(2.5f*Mvmnt);
        if (Diff > Constants.OBSTACLE_RADIUS)
        {
            Destroy(gameObject);
        }
    }
}
