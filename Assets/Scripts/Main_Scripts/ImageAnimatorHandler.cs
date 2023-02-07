using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.UIElements;

public class ImageAnimatorHandler : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleVector;
    [SerializeField] private float duration;
    [SerializeField] AnimationCurve _animationCurve;
    


    // Start is called before the first frame update
    void Awake()
    {
        transform.DOScale(_scaleVector, duration).SetEase(_animationCurve);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
