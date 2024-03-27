using UnityEngine;

public class SeedGrownUp : MonoBehaviour
{
    public void Harvest(Seed seed, PlayerMain playerMain)
    {
        Debug.Log("Seed Harvested");
        playerMain.PlantBag.PlantBagList.Add(seed.gameObject.GetComponent<Plant>());
        seed.gameObject.SetActive(false);
    }
}
