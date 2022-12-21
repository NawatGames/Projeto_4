using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BackFootAnimationHandler : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        _initialX = transform.localPosition.x;
        
        var ida = DOTween.To(Refresh,ti,tf,duration).SetEase(animationCurve);
        var volta = DOTween.To(RefreshLine,_initialX,_initialX + height, duration).SetEase(animationCurve);

        var sequency = DOTween.Sequence().Append(ida).Append(volta).SetLoops(-1).Play();
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
}
