using TMPro;
using UnityEngine;

/// <summary>
/// Class to manage player's money on UI
/// </summary>
public class PlayerMoneyUI : MonoBehaviour
{
    [SerializeField]
    private PlayerMoney _playerMoney;
    [SerializeField]
    private TextMeshProUGUI _moneyText;

    private void Start()
    {
        _playerMoney.MoneyAmountChanged += Notify;
        _moneyText.text = $" $ {_playerMoney.GetMoneyAmount()}";
    }

    public void Notify(int newMoney)
    {
        _moneyText.text = $" $ {newMoney}";
    }
}
