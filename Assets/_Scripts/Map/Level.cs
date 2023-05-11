using UnityEngine;
using Zenject;

public class Level : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform[] _spawnPoints;
    private CoinFactory _coinFactory;

    #endregion

    #region Constructors

    [Inject]
    private void Construct(CoinFactory coinFactory)
    {
        _coinFactory = coinFactory;
        _coinFactory.Init(_spawnPoints);
        
        _coinFactory.Create(transform);
    }

    #endregion
}