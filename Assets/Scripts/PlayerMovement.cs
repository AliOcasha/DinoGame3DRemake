using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public Transform Tile;

    private float TileWidth;

    private Rigidbody Player;
    void Start()
    {
        TileWidth = Tile.transform.localScale.x*Constants.INITIAL_PLANEWIDTH;
        Player = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Mathf.Abs(transform.position.x) < Mathf.Abs(TileWidth/2)*Constants.BOUNDARY_FACTOR)
        {
            if(Input.GetAxisRaw("Horizontal") != 0)
            {
                transform.Translate(Input.GetAxisRaw("Horizontal")*Constants.PLAYER_SPEED*Vector3.right);
            }
            if(Input.GetAxisRaw("Vertical") != 0 || Input.GetButton("Jump"))
            {
                if (transform.position.y <= 0.5f)
                {
                    Player.AddForce(transform.up * 150);
                }
            }
        } 
        else 
        {
            transform.Translate(-Input.GetAxisRaw("Horizontal")*Constants.THROWBACK*Vector3.right);
        }
    }
}