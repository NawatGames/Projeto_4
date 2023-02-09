using System;
using UnityEngine;
using UnityEngine.Events;

public class DashingController : MonoBehaviour
{
    [SerializeField] private Transform rootTransform;
    [SerializeField] private float dashForce;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    public UnityEvent DashStartEvent;
    private Vector2 movementDirectionVar;
    private bool isDashingActive;
    public void DoDash(Vector2 movementDirection)
    {
        movementDirectionVar = movementDirection;
        DashStartEvent.Invoke();
        isDashingActive = true;
    }

    public void EndDash()
    {
        isDashingActive = false;
    }

    private void FixedUpdate()
    {
        if (isDashingActive)
        {
            rootTransform.position += (Vector3)movementDirectionVar * (dashForce * Time.deltaTime);

        }
    }
}