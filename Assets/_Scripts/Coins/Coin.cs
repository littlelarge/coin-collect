using UnityEngine;

public class Coin : MonoBehaviour
{
    #region Variables

    public CoinActions Actions { get; private set; }

    #endregion

    #region UnityMethods

    private void Awake()
    {
        Actions = GetComponent<CoinActions>();
    }

    #endregion
}