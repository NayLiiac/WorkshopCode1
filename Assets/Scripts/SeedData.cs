using UnityEngine;

/// <summary>
/// ScriptableObject to create Seeds
/// </summary>
[CreateAssetMenu(fileName = "SeedData", menuName = "ScriptableObjects/SeedData", order = 1)]

public class SeedData : ScriptableObject
{
    public string SeedName;
    public int PurchasePrice;
}
