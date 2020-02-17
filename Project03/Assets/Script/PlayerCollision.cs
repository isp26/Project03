using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != movement.color & other.tag != "GOAL")
        {
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("Hit with RED");
            movement.rb.AddForce(-8000, 0, 0);
            movement.enabled = false;
        }

    }


}
