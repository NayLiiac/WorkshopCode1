using System;
using UnityEngine;

/// <summary>
/// Class to manage player's money
/// </summary>
public class PlayerMoney : MonoBehaviour
{
    [SerializeField]
    private int _moneyAmount;

    public event Action<int> MoneyAmountChanged;

    /// <summary>
    /// Allow other script to have an access to player's money
    /// </summary>
    /// <returns> int </returns>
    public int GetMoneyAmount()
    {
        return _moneyAmount;
    }

    /// <summary>
    /// Allows to set player's money and invoke an event in order to change the player's money on UI
    /// </summary>
    /// <param name="money"></param>
    public void SetMoneyAmount(int money)
    {
        _moneyAmount = money;
        MoneyAmountChanged?.Invoke(_moneyAmount);
    }
}
