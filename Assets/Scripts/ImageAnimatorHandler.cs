using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.UIElements;

public class ImageAnimatorHandler : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleVector;
    [SerializeField] private float scaleDuration;
    [SerializeField] AnimationCurve _animationScaleCurve;
    
    
    
    [SerializeField] AnimationCurve _animationMoveCurve;
    [SerializeField] private Vector3 _imageMovementVector;
    [SerializeField] private float movementDuration;
    
    

    // Start is called before the first frame update
    void Awake()
    {
        transform.DOScale(_scaleVector, scaleDuration).SetEase(_animationScaleCurve);
    }

    public void OnEnable()
    {
        transform.DOLocalMove(_imageMovementVector, movementDuration).SetEase(_animationMoveCurve);
    }
}
