using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Scene Game = SceneManager.GetActiveScene();
            SceneManager.LoadScene(Game.name);
        }
    }
}
