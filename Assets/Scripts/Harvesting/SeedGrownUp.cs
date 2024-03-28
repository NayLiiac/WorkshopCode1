using UnityEngine;

public class SeedGrownUp : MonoBehaviour
{
    /// <summary>
    /// Allow player to pickup the fully grown up seed, and stocks this new plant in the player's plant bag.
    /// </summary>
    /// <param name="seed"></param>
    /// <param name="playerMain"></param>
    public void Harvest(Seed seed, PlayerMain playerMain)
    {
        playerMain.PlantBag.PlantBagList.Add(seed.gameObject.GetComponent<Plant>());
        seed.gameObject.SetActive(false);
    }
}
