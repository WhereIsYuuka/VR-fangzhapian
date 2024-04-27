using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShowButton_dotween : MonoBehaviour
{
    public float scale = 1f;
    public float duration = 1f;
    private void Awake() {
        transform.localScale = Vector3.zero;
        ShowButton();
    }

    public void ShowButton()
    {
        transform.DOScale(scale, duration).SetEase(Ease.OutElastic).SetLoops(1, LoopType.Restart);
    }
}
