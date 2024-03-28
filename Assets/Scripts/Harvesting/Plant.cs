using UnityEngine;

public class Plant : MonoBehaviour
{
    [field: SerializeField]
    public string PlantName { get; private set; }

    [field: SerializeField]
    public int SellingPrice { get; private set; }
}
