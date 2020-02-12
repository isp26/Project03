using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartStage ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
