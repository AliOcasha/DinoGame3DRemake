using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    /*
    With Keyboard inputs the player can be moved when all conditions are met.
    Conditions:
    Moving right and left when in tile range. ELSE throwback in oppsite of player input
    Jumping if ground contact given.
    */
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
                float factor = Constants.MID_AIR_PLAYER_SPEED;
                if (transform.position.y <= Constants.CONTACT_HEIGHT)
                {
                    factor = 1f;
                }
                transform.Translate(factor*Input.GetAxisRaw("Horizontal")*Constants.PLAYER_SPEED*Vector3.right);
            }
            if(Input.GetAxisRaw("Vertical") != 0 || Input.GetButton("Jump"))
            {
                if (transform.position.y <= Constants.CONTACT_HEIGHT)
                {
                    Player.AddForce(transform.up * Constants.JUMP_FORCE);
                }
            }
        } 
        else 
        {
            transform.Translate(-Input.GetAxisRaw("Horizontal")*Constants.THROWBACK*Vector3.right);
        }
    }
}