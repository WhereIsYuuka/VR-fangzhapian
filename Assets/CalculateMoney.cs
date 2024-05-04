using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateMoney : MonoBehaviour
{
    public int money = 0;
    public Text text;

    private void Awake() {
        text.text = money.ToString();
    }
    public void AddNum(int num)
    {
        money += num;
        text.text = money.ToString();
    }

    public void SubNum(int num)
    {
        money -= num;
        text.text = money.ToString();
    }
}
