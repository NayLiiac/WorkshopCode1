using UnityEngine;

/// <summary>
/// Main for Harvesting classes
/// </summary>
public class HarvesterMain : MonoBehaviour
{
    public TilledDirt Dirt;
    public SowSeed Sow;
    public GrowSeed Grow;
    public SeedGrownUp GrownUp;

    private void Start()
    {
        Dirt = GetComponent<TilledDirt>();
        Sow = GetComponent<SowSeed>();
        Grow = GetComponent<GrowSeed>();
        GrownUp = GetComponent<SeedGrownUp>();
    }
}
