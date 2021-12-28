using UnityEngine;
/*
Constants used all over the project are set here
*/

public class Constants : MonoBehaviour
{
    public const float BASE_SPEED = -0.5f;

    public const float INITIAL_PLANEWIDTH = 10f;

    public const float BOUNDARY_FACTOR = 0.93f;

    public const float OBSTACLE_BOUNDARY_FACTOR = BOUNDARY_FACTOR*0.9f;

    public const float BIRD_BOUNDARY_FACTOR = BOUNDARY_FACTOR*0.8f;

    public const float PLAYER_SPEED = 0.1f;

    public const float THROWBACK = 0.5f;

    public const float CONTACT_HEIGHT = 0.5f;

    public const float JUMP_FORCE = 100;

    public const float MID_AIR_PLAYER_SPEED = 0.2f;

    public const float DAY_SPEED = 0.01f;

    public const float OBSTACLE_RADIUS = 100f;

    public const int SPAWN_RATE = 150;
}
