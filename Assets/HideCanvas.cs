using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HideCanvas : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HideCanva());
        // canvas.transform.DOScale(0, 5f)
        // .SetRelative(true)
        // .SetEase(Ease.OutQuart)
        // .SetLoops(-1, LoopType.Restart);
    }

    IEnumerator HideCanva()
    {
        yield return new WaitForSeconds(3f);
        canvas.transform.DOScale(0, 1f);
    }
}
