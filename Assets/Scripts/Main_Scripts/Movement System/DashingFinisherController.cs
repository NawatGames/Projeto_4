using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DashingFinisherController : MonoBehaviour
{
    [SerializeField] private DashingController dashingController;
    [SerializeField] private float dashDuration;
    public UnityEvent DashFinishedEvent;

    private void OnEnable()
    {
        dashingController.DashStartEvent.AddListener(OnDashStart);
    }

    private void OnDisable()
    {
        dashingController.DashStartEvent.RemoveListener((OnDashStart));
    }

    private void OnDashStart()
    {
        StartCoroutine(StartDash());
    }

    private IEnumerator StartDash()
    {
        yield return new WaitForSeconds(dashDuration);
        
        DashFinishedEvent.Invoke();
    }
}