using System;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField]
    private int _moneyAmount;

    public event Action<int> MoneyAmountChanged;

    public int GetMoneyAmount()
    {
        return _moneyAmount;
    }

    public void SetMoneyAmount(int money)
    {
        _moneyAmount = money;
        MoneyAmountChanged?.Invoke(_moneyAmount);
    }
}
