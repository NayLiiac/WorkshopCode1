using TMPro;
using UnityEngine;

public class PlayerMoneyUI : MonoBehaviour
{
    [SerializeField]
    private PlayerMoney _playerMoney;
    [SerializeField]
    private TextMeshProUGUI _moneyText;

    private void Start()
    {
        _playerMoney.MoneyAmountChanged += Notify;
        _moneyText.text = _playerMoney.GetMoneyAmount().ToString();
    }

    public void Notify(int newMoney)
    {
        _moneyText.text = $" $ {newMoney}";
    }
}
