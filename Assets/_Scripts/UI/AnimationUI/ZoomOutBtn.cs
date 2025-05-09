using System;
using DG.Tweening;
using UnityEngine;

public class ZoomOutBtn : MonoBehaviour
{
    public float time = 0.5f;
    
    

    private void OnEnable()
    {
        AnimationGameObjectZoomOut();
    }

    private void AnimationGameObjectZoomOut()
    {
        var targetLocalScale = transform.localScale;
        transform.localScale = Vector3.zero;
        DOTween.Sequence()
            .SetId("AnimationZoomOutButton")
            .Append(transform.DOScale(targetLocalScale * 1.1f, time))
            .Append(transform.DOScale(targetLocalScale, 0.1f))
            .SetUpdate(true);



    }

    private void OnDestroy()
    {
        DOTween.Kill("AnimationZoomOutButton");
    }

   
}