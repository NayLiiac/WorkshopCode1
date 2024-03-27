using TMPro;
using UnityEngine;

public class BuySeed : MonoBehaviour
{
    [SerializeField]
    private PlayerMain _playerMain;
    [SerializeField]
    private TextMeshProUGUI _boughtSeedText;

    public void SeedBought(Seed seed)
    {
        _boughtSeedText.gameObject.SetActive(true);
        if (_playerMain.Money.GetMoneyAmount() >= seed.PurchasePrice)
        {
            _playerMain.SeedBag.SeedBagList.Add(seed);
            _playerMain.Money.SetMoneyAmount(_playerMain.Money.GetMoneyAmount() - seed.PurchasePrice);
            _boughtSeedText.text = $"Thank you for your purchase !";
        }
        else
        {
            _boughtSeedText.text = $"You don't have enough money to buy this seed !";
        }
    }
}
