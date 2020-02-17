using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextStage : MonoBehaviour
{
    public void StartNextStage ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
