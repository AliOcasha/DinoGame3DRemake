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
    private float[] Heights = {-0.5f,0.5f,0.5f};
    private float SpawnRadius, Pos, Min, Max, Variation;
    private int Type, Counter;

    private Vector3 SpawnVector;

    void FixedUpdate()
    {
        SpawnRadius = (Tile.transform.localScale.x*Constants.INITIAL_PLANEWIDTH)/2;
        Min = -Mathf.Abs(SpawnRadius)*Constants.OBSTACLE_BOUNDARY_FACTOR;
        Max = Mathf.Abs(SpawnRadius)*Constants.OBSTACLE_BOUNDARY_FACTOR;
        Pos = Random.Range(Min,Max);
        Type = Random.Range(0,3);
        Variation = Random.Range(-2,2);
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
                SpawnVector = new Vector3(Pos,Heights[Type],Player.transform.position.z + Constants.OBSTACLE_RADIUS + Variation);
                Instantiate(ObstacleTypes[Type],SpawnVector,Quaternion.identity);
                
            }
        }
    }
}
