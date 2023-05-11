using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerFactoryInstaller : MonoInstaller
{
    #region Variables

    [SerializeField] private PlayerFactory _playerFactory;

    #endregion

    #region Methods

    public override void InstallBindings()
    {
        Container.Bind<PlayerFactory>()
            .FromInstance(_playerFactory)
            .AsSingle();
    }

    #endregion
}
