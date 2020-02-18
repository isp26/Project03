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
    public GameObject playerMAT;
    public Material RED;
    public Material GREEN;
    public Material BLUE;


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
                rb.GetComponent<Renderer>().material = GREEN;
                color = "GREEN";
                Debug.Log("Color changed GREED");
                timestamp = Time.time + timeBetween;
            }
            else if ( Time.time >= timestamp && color == "GREEN")
            {
                rb.GetComponent<Renderer>().material = BLUE;
                color = "BLUE";
                Debug.Log("Color changed BLUE");
                timestamp = Time.time + timeBetween;
            }
            else if ( Time.time >= timestamp && color == "BLUE" )
            {
                rb.GetComponent<Renderer>().material = RED;
                color = "RED";
                Debug.Log("Color Changed RED");
                timestamp = Time.time + timeBetween;
            }
        }

        if (Input.GetKeyUp("k"))
        {
            if ( Time.time >= timestamp && color == "RED")
            {
                rb.GetComponent<Renderer>().material = BLUE;
                color = "BLUE";
                Debug.Log("Color changed BLUE");
                timestamp = Time.time + timeBetween;
            }
            else if ( Time.time >= timestamp && color == "GREEN")
            {
                rb.GetComponent<Renderer>().material = RED;
                color = "RED";
                Debug.Log("Color changed RED");
                timestamp = Time.time + timeBetween;
            }
            else if ( Time.time >= timestamp && color == "BLUE" )
            {
                rb.GetComponent<Renderer>().material = GREEN;
                color = "GREEN";
                Debug.Log("Color Changed GREEN");
                timestamp = Time.time + timeBetween;
            }
        }
    }
}
