using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float playerDistance;
    public bool speedUpAgain = true;

    void Update()
    {
        scoreText.text = player.position.x.ToString("0");
        playerDistance = player.position.x;
        if (playerDistance == 500 && speedUpAgain == true)
        {
            player.GetComponent<PlayerMovement>().forwardForce += 2000;
            Debug.Log("Speed UP!");
            speedUpAgain = false;
        }
        if (playerDistance == 1000)
        {
            speedUpAgain = true;
        }
        if (playerDistance == 1500)
        {
            speedUpAgain = true;
        }
        if (playerDistance == 2000)
        {
            speedUpAgain = true;
        }
        if (playerDistance == 2500)
        {
            speedUpAgain = true;
        }
        if (playerDistance == 3000)
        {
            speedUpAgain = true;
        }
    }



}
