using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Map : MonoBehaviour
{
    #region Variables

    private Level _level;
    private PlayerFactory _playerFactory;
    private LevelFactory _levelFactory;

    #endregion

    #region Constructors

    [Inject]
    private void Construct(PlayerFactory playerFactory, LevelFactory levelFactory)
    {
        _playerFactory = playerFactory;
        _levelFactory = levelFactory;
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
        if (_level != null)
            Destroy(_level.gameObject);

        _levelFactory.Create();
        _playerFactory.Create();
    }
    
    #endregion
}