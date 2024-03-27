using UnityEngine;

public class TilledDirt : MonoBehaviour
{
    [SerializeField]
    private bool _hasSeedOnIt;

    public bool HasSeedOnThisDirt()
    {
        return _hasSeedOnIt;
    }

    public void SetSeedOnThisDirt(bool hasSeedOnThisDirt)
    {
        _hasSeedOnIt = hasSeedOnThisDirt;
    }
}
