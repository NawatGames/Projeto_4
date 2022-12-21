using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MemberAnimationHandler : MonoBehaviour
{
    public string AnimationState;
    public float duration;

    public AnimationCurve animationCurve;

    public float ti;
    public float tf;

    public Vector2 offset;

    public float xAxisElipse;
    public float yAxisElipse;
    private Sequence _sequence;


    // Start is called before the first frame update
    void Awake()
    {
        var ida = DOTween.To(Refresh,ti,tf,duration).SetEase(animationCurve);
        var volta = DOTween.To(Refresh,tf,ti,duration).SetEase(animationCurve);
        
        _sequence = DOTween.Sequence().Append(ida).Append(volta).SetLoops(-1);
        _sequence.Pause();
    }
    void Refresh(float value)
    {
        var position = new Vector2(xAxisElipse*Mathf.Cos(value), yAxisElipse*Mathf.Sin(value)) + offset;

        transform.localPosition = (Vector3)position;
    }

    private void OnEnable()
    {
        _sequence.Restart();
        _sequence.Play();
    }

    private void OnDisable()
    {
        _sequence.Pause();
    }
}

