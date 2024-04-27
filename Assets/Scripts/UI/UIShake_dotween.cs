using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIShake_dotween : MonoBehaviour
{
    public float scale = 1f;
    private void Awake() {
        StartShake();
    }

    void StartShake()
    {
        transform.DOScale(scale, 1f)
        .SetRelative(true)
        .SetEase(Ease.OutQuart)
        .SetLoops(-1, LoopType.Restart);
    }
}
