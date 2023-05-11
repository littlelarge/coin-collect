using UnityEngine;
using Zenject;

public class CoinsSpawnPoints : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    private CoinFactory _coinFactory;

    #region Constructors

    [Inject]
    private void Construct(CoinFactory coinFactory)
    {
        _coinFactory = coinFactory;
        _coinFactory.Init(_spawnPoints);
        
        _coinFactory.Create();
    }

    #endregion
}