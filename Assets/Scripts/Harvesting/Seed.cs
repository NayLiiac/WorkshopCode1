using UnityEngine;

public class Seed : MonoBehaviour
{
    public Animator GrowSeedAnim;
    [SerializeField]
    private bool _isSeedGrownUp;

    [field : SerializeField]
    public string SeedName { get; private set; }

    [field : SerializeField]
    public int PurchasePrice { get; private set; }

    public void SeedGrowthStartAnim()
    {
        GrowSeedAnim.SetTrigger("Grow");
    }

    /// <summary>
    /// Called by the animator in the end of the animation to set that this seed is fully grown.
    /// </summary>
    public void SetSeedGrownUp()
    {
        _isSeedGrownUp = true;
    }

    /// <summary>
    /// Access to the seed state, allows to know if a seed is fully grown or not.
    /// </summary>
    /// <returns> bool </returns>
    public bool GetSeedGrownUp()
    {
        return _isSeedGrownUp;
    }
}
