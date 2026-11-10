using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
#if UNITY_EDITOR // editörde isek kullanılır
        UnityEditor.EditorApplication.isPlaying = false;
#else // editörde değilsek
        Application.Quit();
#endif // şartın sonu
    }
    private void Update()
    {
        if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                QuitGame();
            }
        }
    }
}

