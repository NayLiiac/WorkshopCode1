using UnityEngine;

public class SowSeed : MonoBehaviour
{
    [SerializeField]
    private Seed _sowedSeed;
    [SerializeField]
    private HarvesterMain _harvesterMain;
    [SerializeField]
    private Transform _spawnpoint;

    private void Start()
    {
        _harvesterMain.GetComponent<HarvesterMain>();
    }

    public void SowASeed(Seed seed)
    {
        _sowedSeed = Instantiate(seed, _spawnpoint);
        _harvesterMain.Dirt.SetSeedOnThisDirt(true);
        _harvesterMain.Grow.StartGrowingSeed(seed);
    }

    /// <summary>
    /// Allows to know which seed is growing/grown up.
    /// </summary>
    /// <returns> Seed </returns>
    public Seed GetSowedSeed()
    {
        return _sowedSeed;
    }

    /// <summary>
    /// Set seed planted.
    /// </summary>
    /// <param name="seed"></param>
    public void SetSowedSeed(Seed seed)
    {
        _sowedSeed = seed;
    }
}
