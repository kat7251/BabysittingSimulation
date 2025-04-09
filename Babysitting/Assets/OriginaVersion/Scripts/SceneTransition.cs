using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("1 Start Scene"); // 👈 Make sure this scene is added in Build Settings
    }
}
