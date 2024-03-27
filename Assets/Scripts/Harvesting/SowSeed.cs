using UnityEngine;

public class SowSeed : MonoBehaviour
{
    public Seed SowedSeed;
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
        Debug.Log("Seed Sowed");

        SowedSeed = Instantiate(seed, _spawnpoint);
        _harvesterMain.Dirt.SetSeedOnThisDirt(true);
        _harvesterMain.Grow.StartGrowingSeed(seed);
    }
}
