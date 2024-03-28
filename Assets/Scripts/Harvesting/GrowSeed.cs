using UnityEngine;

public class GrowSeed : MonoBehaviour
{
    /// <summary>
    /// Allows to trigger the animation in order to make a seed growing.
    /// </summary>
    /// <param name="seed"></param>
    public void StartGrowingSeed(Seed seed)
    {
        seed.SeedGrowthStartAnim();
    }
}
