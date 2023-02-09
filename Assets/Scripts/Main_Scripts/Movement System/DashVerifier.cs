using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashVerifier : MonoBehaviour
{
    [SerializeField] private DashingController dashingController;
    [SerializeField] private DashingFinisherController dashingFinisherController;

    private bool isDashing;

    private void OnEnable()
    {
        dashingController.DashStartEvent.AddListener(OnDashingStart);
        dashingFinisherController.DashFinishedEvent.AddListener((OnDashingFinished));
    }

    private void OnDashingFinished()
    {
        isDashing = false;

    }

    private void OnDisable()
    {
        dashingController.DashStartEvent.RemoveListener(OnDashingStart);
        dashingFinisherController.DashFinishedEvent.RemoveListener((OnDashingFinished));

    }

    private void OnDashingStart()
    {
        isDashing = true;
    }

    public bool Verify()
    {
        return !isDashing;
    }
}
