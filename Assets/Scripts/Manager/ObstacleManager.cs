using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public Transform Player;
    public Transform Tile;
    public List<GameObject> ObstacleTypes;
    private float[] Heights = {-0.5f,0.5f,0.5f};
    private float TileWidth;
    private int Type;
    private float Pos;
    private int Counter;

    void Update()
    {
        Counter++;
        // every 200 Frames ca. 1.5 seconds
        if (Counter == 200)
        {
            Counter = 0;
            for (int i = 0; i < 3; i++)
            {
                Type = Random.Range(0,3);
                TileWidth = Tile.transform.localScale.x*Constants.INITIAL_PLANEWIDTH;
                Pos = Random.Range(-Mathf.Abs(TileWidth/2)*Constants.BOUNDARY_FACTOR,Mathf.Abs(TileWidth/2)*Constants.BOUNDARY_FACTOR*0.9f);
                Instantiate(ObstacleTypes[Type],new Vector3(Pos,Heights[Type],Player.transform.position.z + 30),Quaternion.identity);
            }
        }
    }
}
