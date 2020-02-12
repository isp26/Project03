using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement movement;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        movement.rb.AddForce(-2000, 0, 0);
        movement.enabled = false;
    }
}
