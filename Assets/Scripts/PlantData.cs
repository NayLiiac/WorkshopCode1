using UnityEngine;

/// <summary>
/// ScriptableObject to create Plants
/// </summary>
[CreateAssetMenu(fileName = "PlantData", menuName = "ScriptableObjects/PlantData", order = 2)]

public class PlantData : ScriptableObject
{
    public string PlantName;
    public int PlantSellingPrice;
}
