using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FrontFootAnimationHandler : MonoBehaviour
{
    public string AnimationState;
    public float height;
    private float _initialX;

    public float duration;

    public AnimationCurve animationCurve;

    public float ti;
    public float tf;

    public Vector2 offset;

    public float xAxisElipse;
    public float yAxisElipse;

    public float phase = 0;
    private Sequence _sequence;

    // Start is called before the first frame update
    void Awake()
    {
        _initialX = transform.localPosition.x;
        
        var volta = DOTween.To(RefreshLine,_initialX,_initialX + height, duration).SetEase(animationCurve);
        var ida = DOTween.To(Refresh,ti,tf,duration).SetEase(animationCurve);
        
        _sequence = DOTween.Sequence().Append(volta).Append(ida).SetLoops(-1);
        _sequence.Pause();
    }
    
    void Refresh(float value)
    {
        var tm = _initialX + (height / 2);
        var position = new Vector2(xAxisElipse*Mathf.Cos(value) + tm, yAxisElipse*Mathf.Sin(value)) + offset;

        transform.localPosition = (Vector3)position;
    }

    void RefreshLine(float value)
    {
        var position = new Vector2(value, 0) + offset;
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


