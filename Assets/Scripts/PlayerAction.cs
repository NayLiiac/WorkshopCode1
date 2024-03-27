using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    private LayerMask _layerMask;

    [Header("Temporary Values")]
    [SerializeField]
    private GameObject _gameObjectTouched;
    private HarvesterMain _tempHarvester;

    [Header("Refs")]
    [SerializeField]
    private PlayerMain _playerMain;
    [SerializeField]
    private SeedMerchant _merchant;

    private void Start()
    {
        _playerMain = GetComponent<PlayerMain>();
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

                        _tempHarvester = _gameObjectTouched.GetComponent<HarvesterMain>();
                        if (_tempHarvester != null && !_tempHarvester.Dirt.HasSeedOnThisDirt())
                        {
                            if (_playerMain.SeedBag.SeedBagList.Count > 0)
                            {
                                Debug.Log("Sow a Seed");
                                _tempHarvester.Sow.SowASeed(_playerMain.SeedBag.SeedBagList[0]);
                                _playerMain.SeedBag.SeedBagList.RemoveAt(0);
                            }

                        }

                        else if (_tempHarvester != null && _tempHarvester.Sow.SowedSeed.GetSeedGrownUp())
                        {
                            Debug.Log("Harvest");
                            _tempHarvester.GrownUp.Harvest(_tempHarvester.Sow.SowedSeed, this._playerMain);
                            _tempHarvester.Sow.SowedSeed = null;
                            _tempHarvester.Dirt.SetSeedOnThisDirt(false);
                        }

                        break;
                }
            }
        }
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
}
