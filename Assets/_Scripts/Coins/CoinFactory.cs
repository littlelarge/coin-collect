using UnityEngine;
using Zenject;

public class CoinFactory : MonoBehaviour
{
    #region Variables

    [SerializeField] private GameObject _coinPrefab;
    
    private Transform[] _spawnPoints;

    private int _prevSpawnPointIndex;
    private DiContainer _diContainer;
    private LevelFactory _levelFactory;

    public Coin Coin { get; private set; }

    #endregion

    #region Constructors

    [Inject]
    private void Construct(DiContainer diContainer, LevelFactory levelFactory)
    {
        _diContainer = diContainer;
        _levelFactory = levelFactory;
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
            _diContainer.InstantiatePrefabForComponent<Coin>(_coinPrefab, _spawnPoints[randomIndex].position, Quaternion.identity, _levelFactory.Level.transform);

        _prevSpawnPointIndex = randomIndex;
    }
    
    public void Create(Transform parent)
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);

        while (randomIndex == _prevSpawnPointIndex)
            randomIndex = Random.Range(0, _spawnPoints.Length);

        Coin = 
            _diContainer.InstantiatePrefabForComponent<Coin>(_coinPrefab, _spawnPoints[randomIndex].position, Quaternion.identity, parent);

        _prevSpawnPointIndex = randomIndex;
    }
    
    #endregion
}