using System;
using System.Collections;
using System.Collections.Generic;
using EventSystem.SimpleEvents;
using Main_Scripts.EventSystem.SimpleEvents;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private IntegerEvent intEventToListen;
    [SerializeField] private NoTypeGameEvent noTypeGameEventToListen;
    
    
    public List<Button> elementsButtons;


    private void OnEnable()
    {
        intEventToListen.SubscribeUnityEvent(OnIntEventCall);
        
    }

    private void OnIntEventCall(int inputIndex)
    {
        Debug.Log(inputIndex);
        if (inputIndex == 1)
        {
            SelectWater();
        }
        if (inputIndex == 2)
        {
            SelectGround();
        }
        if (inputIndex == 3)
        {
            SelectFire();
        }
        if (inputIndex == 4)
        {
            SelectWind();
        }
        if (inputIndex == 5)
        {
            SelectGlass();
        }
    }

    private void SelectWater()
    {
       elementsButtons[0].Select();
    }
    private void SelectGround()
    {
        elementsButtons[1].Select();
    }
    private void SelectFire()
    {
        elementsButtons[2].Select();
    }
    private void SelectWind()
    {
        elementsButtons[3].Select();
    }
    private void SelectGlass()
    {
        elementsButtons[4].Select();
    }
}
