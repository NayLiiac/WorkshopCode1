using TMPro;
using UnityEngine;

public class SellPlant : MonoBehaviour
{
    [SerializeField]
    private PlayerMain _playerMain;
    [SerializeField]
    private TextMeshProUGUI _sellPlantText;

    public void SellOnePlantType(Plant plantToSell)
    {
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

    public void SellAllPlant()
    {
        if (_playerMain.PlantBag.PlantBagList.Count > 0)
        {
            foreach (Plant plant in _playerMain.PlantBag.PlantBagList)
            {
                _playerMain.PlantBag.PlantBagList.Remove(plant);
                _playerMain.Money.SetMoneyAmount(_playerMain.Money.GetMoneyAmount() + plant.SellingPrice);
            }

            _sellPlantText.text = $"Thank you very much !";
        }
    }
}
