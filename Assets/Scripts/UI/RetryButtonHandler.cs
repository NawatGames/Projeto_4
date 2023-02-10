using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonHandler : MonoBehaviour
{
    public void TutorialSceneLoader()
    {
        SceneManager.LoadScene("Tutorial");
    }
}