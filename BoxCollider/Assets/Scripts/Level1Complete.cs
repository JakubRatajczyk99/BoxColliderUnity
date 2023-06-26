using UnityEngine;
using UnityEngine.SceneManagement;
public class Level1Complete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
