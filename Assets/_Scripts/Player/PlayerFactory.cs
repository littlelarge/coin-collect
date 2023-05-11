using System;
using UnityEngine;
using Zenject;

public class PlayerFactory : MonoBehaviour
{
    #region Variables

    [SerializeField] private GameObject _playerPrefab;
    
    private DiContainer _diContainer;

    public Player Player { get; private set; }

    #endregion

    #region Constructors

    [Inject]
    private void Construct(DiContainer diContainer)
    {
        _diContainer = diContainer;
    }

    #endregion

    #region Methods

    public void Create()
    {
        Player = _diContainer.InstantiatePrefabForComponent<Player>(_playerPrefab, Vector3.zero, Quaternion.identity, null);
    }
    
    #endregion
}
