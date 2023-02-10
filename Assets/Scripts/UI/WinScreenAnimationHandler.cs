using DG.Tweening;
using UnityEngine;

public class WinScreenAnimationHandler : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleVector;
    [SerializeField] private float scaleDuration;
    [SerializeField] AnimationCurve _animationScaleCurve;
    
    public void OnEnable()
    {
        transform.DOScale(_scaleVector, scaleDuration).SetEase(_animationScaleCurve);
    }
}