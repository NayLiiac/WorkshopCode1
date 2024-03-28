using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    private LayerMask _layerMask;

    [Header("Refs")]
    [SerializeField]
    private PlayerMain _playerMain;
    [SerializeField]
    private SeedMerchant _merchant;
    [SerializeField]
    private SeedSelectorUI _seedSelectorUI;

    [Header("Temporary Values")]
    [SerializeField]
    private GameObject _gameObjectTouched;

    [field : SerializeField]
    public HarvesterMain TempHarvester { get; private set; }

    private void Start()
    {
        _playerMain = GetComponent<PlayerMain>();
    }

    /// <summary>
    /// Create the raycast in order to interact with the world
    /// </summary>
    /// <returns> Gameobject or null depending of LayerMask used </returns>
    private GameObject CreateRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;

        // Cast a ray from the mouse position and check if it hits an object
        if (Physics.Raycast(ray, out hit, 100f, _layerMask))
        {
            return hit.collider.gameObject;
        }
        else
        {
            return null;
        }
    }

    public void InteractWithWorld(InputAction.CallbackContext ctx)
    {
        if (ctx.started && !GameManager.Instance.AreAnyUIOpened)
        {
            _gameObjectTouched = CreateRaycast();
            if (_gameObjectTouched != null)
            {
                switch (_gameObjectTouched.tag)
                {
                    case "Market":

                        _merchant.OpenMerchantUI();
                        break;
                    case "Dirt":

                        TempHarvester = _gameObjectTouched.GetComponent<HarvesterMain>();
                        if (TempHarvester != null && !TempHarvester.Dirt.HasSeedOnThisDirt())
                        {
                            if (_playerMain.SeedBag.SeedBagList.Count > 0)
                            {
                                _seedSelectorUI.OpenSeedSelectorUI();
                            }
                        }
                        else if (TempHarvester != null && TempHarvester.Sow.GetSowedSeed().GetSeedGrownUp())
                        {
                            TempHarvester.GrownUp.Harvest(TempHarvester.Sow.GetSowedSeed(), this._playerMain);
                            TempHarvester.Sow.SetSowedSeed(null);
                            TempHarvester.Dirt.SetSeedOnThisDirt(false);
                        }

                        break;
                }
            }
        }
    }
}
