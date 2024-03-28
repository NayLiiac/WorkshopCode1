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

    public Seed GetSowedSeed()
    {
        return _sowedSeed;
    }

    public void SetSowedSeed(Seed seed)
    {
        _sowedSeed = seed;
    }
}
