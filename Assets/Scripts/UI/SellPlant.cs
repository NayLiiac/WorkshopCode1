using TMPro;
using UnityEngine;

/// <summary>
/// Class who manages plants selling in the game
/// </summary>
public class SellPlant : MonoBehaviour
{
    [SerializeField]
    private PlayerMain _playerMain;
    [SerializeField]
    private TextMeshProUGUI _sellPlantText;

    /// <summary>
    /// Sell one type of plant from the player's plant bag
    /// </summary>
    /// <param name="plantToSell"></param>
    public void SellOnePlantType(Plant plantToSell)
    {
        _sellPlantText.gameObject.SetActive(true);
        if (_playerMain.PlantBag.PlantBagList.Count > 0)
        {
            bool plantFound = false;
            foreach (Plant plant in _playerMain.PlantBag.PlantBagList)
            {
                if (plant.PlantName == plantToSell.PlantName)
                {
                    _playerMain.PlantBag.PlantBagList.Remove(plant);
                    _playerMain.Money.SetMoneyAmount(_playerMain.Money.GetMoneyAmount() + plant.SellingPrice);
                    plantFound = true;
                    break;
                }
            }

            if (!plantFound)
            {
                _sellPlantText.text = $"You don't have this plant in your bag !";
            }
            else
            {
                _sellPlantText.text = $"Thank you very much !";
            }
        }
        else
        {
            _sellPlantText.text = $"Your bag is empty :'(";
        }
    }

    /// <summary>
    /// Sell all plants in the player's plant bag directly
    /// </summary>
    public void SellAllPlant()
    {
        _sellPlantText.gameObject.SetActive(true);
        if (_playerMain.PlantBag.PlantBagList.Count > 0)
        {
            int plantsBagSales = 0;
            foreach (Plant plant in _playerMain.PlantBag.PlantBagList)
            {
                plantsBagSales += plant.SellingPrice;
            }

            _playerMain.Money.SetMoneyAmount(_playerMain.Money.GetMoneyAmount() + plantsBagSales);
            _playerMain.PlantBag.PlantBagList.Clear();
            _sellPlantText.text = $"Thank you very much !";
        }
        else
        {
            _sellPlantText.text = $"Your bag is empty :'(";
        }
    }
}
