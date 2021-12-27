using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Has to be the same as in GroundMovment
    private float factor = 1;
    private GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate()
    {
        Vector3 Mvmnt = factor* Constants.BASE_SPEED * Vector3.forward;
        transform.Translate(Mvmnt);
        // Has to be bigger or equal than Spawn Radius
        if (Mathf.Abs(Player.transform.position.z - transform.position.z) >= 30)
        {
            Destroy(gameObject);
        }
    }
}
