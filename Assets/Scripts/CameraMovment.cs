using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public Transform Target;
    private Vector3 Offset = new Vector3(0f, 2f, -5f);
    private Quaternion Rotation = Quaternion.Euler(0f,0f,0f);

    /*Positioning the camera in the right position relative to the player,
     after initial positioning relative to (0,0,0)*/
    void Start()
    {
        transform.position = Offset;
        transform.rotation = Rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + Offset; 
    }
}
