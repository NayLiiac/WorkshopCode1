using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton
    private static GameManager _instance = null;

    private GameManager()
    {
    }

    public static GameManager Instance => _instance;

    private void Awake()
    {
        // Singleton
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            _instance = this;
        }
    }

    public bool AreAnyUIOpened { get; private set; }

    public void SetAnyUIOpened(bool areAnyUIOpened)
    {
        AreAnyUIOpened = areAnyUIOpened;
    }
}
