using TMPro;
using UnityEngine;

/// <summary>
/// Class who manages seeds buying in the game
/// </summary>
public class BuySeed : MonoBehaviour
{
    [SerializeField]
    private PlayerMain _playerMain;
    [SerializeField]
    private TextMeshProUGUI _boughtSeedText;

    /// <summary>
    /// Method called by buttons in the Seed Merchant, allows player to buy new seeds of his choice, depending of its money.
    /// </summary>
    /// <param name="seed"></param>
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
