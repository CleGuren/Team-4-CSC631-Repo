using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    // public void Start() {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }

    // public void EndGame() {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    // }
}
