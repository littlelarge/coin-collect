using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MapInstaller : MonoInstaller
{
    #region Variables

    [SerializeField] private Map _map;
    
    #endregion

    #region UnityMethods
    #endregion

    #region Methods

    public override void InstallBindings()
    {
        Container.Bind<Map>()
            .FromInstance(_map)
            .AsSingle();
    }

    #endregion
}
