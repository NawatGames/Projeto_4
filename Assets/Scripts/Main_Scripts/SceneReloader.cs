using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    public float delay;

    public void ReloadScene(){
        StartCoroutine(destroyCountdown());
    }
    
    private IEnumerator destroyCountdown(){
            yield return new WaitForSeconds(delay);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
}
