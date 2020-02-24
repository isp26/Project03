using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public PlayerMovement movement;
    public GameObject completeLevelUI;
    public GameObject restratLevelUI;
    public Transform player;

    //Start spawn scripts
    public GameObject[] objects;                // The prefab to be spawned.     
    private Vector3 spawnPosition;
    public float timeBetween = 5f;
    private float timestamp;
    public AudioSource backGroundMusic;

    void Update()
    {
        if (Time.time >= timestamp )
        {
            Spawn();
            timestamp = Time.time + timeBetween;
            if (timeBetween <= 1)
            {
                timeBetween = 1;
            }
            else
            {
                timeBetween -= 0.15f;
            }
        }
    }


    void Spawn()
    {
        spawnPosition.x = player.position.x + 350;
        spawnPosition.y = 1;
        spawnPosition.z = 0;

        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length)], spawnPosition, Quaternion.identity);
    }
    //Ends spawn scripts

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);

    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            movement.enabled = false;
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }  
    }
    
    void Restart ()
    {
        backGroundMusic.enabled = false;
        restratLevelUI.SetActive(true);
        FindObjectOfType<SoundManager>().error();
    }

}
