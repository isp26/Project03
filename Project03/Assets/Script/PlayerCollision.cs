using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioSource backGroundMusic;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<SoundManager>().crash();
            Debug.Log("OFFmusic");
            backGroundMusic.enabled = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != movement.color & other.tag != "GOAL")
        {
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<SoundManager>().crash();
            Debug.Log("Hit with RED");
            float currentForce = movement.forwardForce;
            movement.rb.AddForce(-currentForce, 0, 0);
            movement.enabled = false;
            backGroundMusic.enabled = false;
        }

    }


}
