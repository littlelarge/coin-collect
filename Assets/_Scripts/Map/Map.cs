using UnityEngine;
using Zenject;

public class Map : MonoBehaviour
{
    #region Variables

    private PlayerFactory _playerFactory;
    private LevelFactory _levelFactory;
    private GameGlobalEvents _gameGlobalEvents;

    #endregion

    #region Constructors

    [Inject]
    private void Construct(PlayerFactory playerFactory, LevelFactory levelFactory, GameGlobalEvents gameGlobalEvents)
    {
        _playerFactory = playerFactory;
        _levelFactory = levelFactory;
        _gameGlobalEvents = gameGlobalEvents;
    }

    #endregion

    #region UnityMethods

    private void Start()
    {
        LoadLevel();
    }

    #endregion

    #region Methods

    public void LoadLevel()
    {
        if (_levelFactory.Level != null)
            Destroy(_levelFactory.Level.gameObject);

        _levelFactory.Create(transform);
        _playerFactory.Create(_levelFactory.Level.transform);
        
        _gameGlobalEvents.OnLevelLoad.Invoke();
    }
    
    #endregion
}