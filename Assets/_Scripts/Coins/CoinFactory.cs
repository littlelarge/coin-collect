using System;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

public class CoinFactory : MonoBehaviour
{
    #region Variables

    [SerializeField] private GameObject _coinPrefab;
    
    private Transform[] _spawnPoints;

    private int _prevSpawnPointIndex;
    private DiContainer _diContainer;

    public Coin Coin { get; private set; }

    #endregion

    #region Constructors

    [Inject]
    private void Construct(DiContainer diContainer)
    {
        _diContainer = diContainer;
    }

    #endregion

    #region Methods
    
    public void Init(Transform[] spawnPoints)
    {
        _spawnPoints = spawnPoints;
    }
    
    public void Create()
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);

        while (randomIndex == _prevSpawnPointIndex)
            randomIndex = Random.Range(0, _spawnPoints.Length);

        Coin = 
            _diContainer.InstantiatePrefabForComponent<Coin>(_coinPrefab, _spawnPoints[randomIndex].position, Quaternion.identity, null);

        _prevSpawnPointIndex = randomIndex;
    }
    
    #endregion
}