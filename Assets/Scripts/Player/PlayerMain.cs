using UnityEngine;

/// <summary>
/// Main for Player classes
/// </summary>
public class PlayerMain : MonoBehaviour
{
    public PlayerSeedBag SeedBag;
    public PlayerPlantBag PlantBag;
    public PlayerMoney Money;
    [field : SerializeField]
    public PlayerAction PlAction { get; private set; }
}
