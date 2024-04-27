using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonController_dotween : MonoBehaviour
{
    private void Awake() {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ShowSprite);
    }

    public void ShowSprite()
    {
        transform.DOScale(1, 0.5f).SetEase(Ease.OutElastic);
        GetComponentInChildren<Image>().DOFade(1, 0.5f);
    }
}
