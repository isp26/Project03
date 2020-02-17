using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public GameObject blueTAG;
    public GameObject redTAG;
    public GameObject greenTAG;
    public string color = "RED";
    public float timeBetween = 0.2f; 
    private float timestamp;

    void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
        if (Input.GetKeyUp("l"))
        {
            if ( Time.time >= timestamp && color == "RED")
            {
                redTAG.SetActive(false);
                greenTAG.SetActive(true);
                color = "GREEN";
                Debug.Log("Color changed GREED");
                timestamp = Time.time + timeBetween;
            }
            else if ( Time.time >= timestamp && color == "GREEN")
            {
                greenTAG.SetActive(false);
                blueTAG.SetActive(true);
                color = "BLUE";
                Debug.Log("Color changed BLUE");
                timestamp = Time.time + timeBetween;
            }
            else if ( Time.time >= timestamp && color == "BLUE" )
            {
                blueTAG.SetActive(false);
                redTAG.SetActive(true);
                color = "RED";
                Debug.Log("Color Changed RED");
                timestamp = Time.time + timeBetween;
            }

        }
    }
}
