using UnityEngine;

public class CoinActions : MonoBehaviour, ICollectable
{
    #region Variables

    private Coin _coin;

    #endregion

    #region UnityMethods

    private void Awake()
    {
        _coin = GetComponent<Coin>();
    }

    #endregion

    #region Methods
    
    public void Collect()
    {
        _coin.Events.OnCollect.Invoke();
    }

    #endregion
}