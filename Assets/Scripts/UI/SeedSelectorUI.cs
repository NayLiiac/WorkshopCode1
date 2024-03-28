using UnityEngine;

/// <summary>
/// Class who open and close the seed selector, used when a player wants to sow a seed.
/// </summary>
public class SeedSelectorUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _seedSelector;

    public void OpenSeedSelectorUI()
    {
        GameManager.Instance.SetAnyUIOpened(true);
        _seedSelector.SetActive(true);
    }

    public void CloseSeedSelectorUI()
    {
        GameManager.Instance.SetAnyUIOpened(false);
        _seedSelector.SetActive(false);
    }
}
