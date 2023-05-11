using UnityEngine;
using Zenject;

public class CoinTrigger : MonoBehaviour
{
    #region Variables

    private CoinFactory _coinFactory;

    #endregion
    
    #region Constructors

    [Inject]
    private void Construct(CoinFactory coinFactory)
    {
        _coinFactory = coinFactory;
    }

    #endregion

    #region UnityMethods
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICollector collector))
        {
            _coinFactory.Coin.Actions.Collect();
        }
    }
    
    #endregion
}