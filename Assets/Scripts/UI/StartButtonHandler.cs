using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHandler : MonoBehaviour
{
    [SerializeField] private Animator _animator;


    public void TutorialSceneLoader()
    {
        SceneManager.LoadScene("Tutorial");
    }
    
    public void Animationloader()
    {
        _animator.SetBool("buttonPressed", true);
    }
}
