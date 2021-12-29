using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    /*
    Picking a Random Prefab and the height needed for it and than spawning it on a random Position in
    a given distance infront of the Player on the Tile
    */
    public Transform Player, Tile;
    public List<GameObject> ObstacleTypes;
    public GameObject Bird;
    
    private float Height = -1;
    private float BirdHeight = 5;
    private float SpawnRadius, Pos, Min, Max, Variation;
    private int Type, Counter;

    private Vector3 SpawnVector;

    void GenerateRandoms()
    {
        SpawnRadius = (3*Constants.INITIAL_PLANEWIDTH)/2;
        Min = -Mathf.Abs(SpawnRadius);
        Max = Mathf.Abs(SpawnRadius);
        Pos = Random.Range(Min,Max);
        Type = Random.Range(0,4);
        Variation = Random.Range(-3,3);
    }
    void Update()
    {
        Counter++;
        // every x Frames (100 Frames ca. 1 second)
        if (Counter == Constants.SPAWN_RATE)

        {
            Counter = 0;
            for (int i = 0; i < 5; i++)
            {
                GenerateRandoms();
                SpawnVector = new Vector3(Pos*Constants.OBSTACLE_BOUNDARY_FACTOR,
                Height,
                Player.transform.position.z + Constants.OBSTACLE_RADIUS + Variation);
                Instantiate(ObstacleTypes[Type],SpawnVector,Quaternion.identity);    
            }
            for (int i = 0; i < 3; i++)
            {
                GenerateRandoms();
                SpawnVector = new Vector3(Pos*Constants.BIRD_BOUNDARY_FACTOR,
                BirdHeight,
                Player.transform.position.z + Constants.OBSTACLE_RADIUS + Variation);
                Instantiate(Bird,SpawnVector,Quaternion.identity);    
            }
        }
    }
}
