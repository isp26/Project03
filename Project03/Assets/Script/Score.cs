using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float playerDistance;
    public bool speedUpAgain = true;
    public float playerSpeedUpAgain = 0;


    void Update()
    {
        scoreText.text = player.position.x.ToString("0");
        playerDistance = player.position.x + playerSpeedUpAgain;

        if (playerDistance > 500)
        {
            playerSpeedUpAgain -= 500;
            player.GetComponent<PlayerMovement>().forwardForce += 500;
            Debug.Log("Speed UP!");
        }
    }



}
