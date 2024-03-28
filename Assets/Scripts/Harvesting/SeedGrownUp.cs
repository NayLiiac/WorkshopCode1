using UnityEngine;

public class SeedGrownUp : MonoBehaviour
{
    public void Harvest(Seed seed, PlayerMain playerMain)
    {
        playerMain.PlantBag.PlantBagList.Add(seed.gameObject.GetComponent<Plant>());
        seed.gameObject.SetActive(false);
    }
}
