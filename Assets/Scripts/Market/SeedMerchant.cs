using UnityEngine;

public class SeedMerchant : MonoBehaviour
{
    [SerializeField]
    private GameObject _merchantUI;

    public void OpenMerchantUI()
    {
        GameManager.Instance.SetAnyUIOpened(true);
        _merchantUI.SetActive(true);
    }

    public void CloseMerchantUI()
    {
        GameManager.Instance.SetAnyUIOpened(false);
        _merchantUI.SetActive(false);
    }
}
