using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreenHandler : MonoBehaviour
{
    
    [SerializeField] private GameObject winScreen;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider != null)
        {
            winScreen.SetActive(true);
        } 
    }
}
