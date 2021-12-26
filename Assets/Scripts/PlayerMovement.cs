using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public Transform Tile;

    private float TileWidth;
    void Start()
    {
        TileWidth = Tile.transform.localScale.x*Constants.INITIAL_PLANEWIDTH;
    }

    void FixedUpdate()
    {
        if (Mathf.Abs(transform.position.x) < Mathf.Abs(TileWidth/2)*Constants.BOUNDARY_FACTOR)
        {
            if(Input.GetAxisRaw("Horizontal") != 0)
            {
                transform.Translate(Input.GetAxisRaw("Horizontal")*Constants.PLAYER_SPEED*Vector3.right);
            }
        } 
        else 
        {
            transform.Translate(-Input.GetAxisRaw("Horizontal")*Constants.THROWBACK*Vector3.right);
        }
    }
}