using UnityEngine;
using Zenject;

public class LevelFactoryInstaller : MonoInstaller
{
    #region Variables

    [SerializeField] private LevelFactory _levelFactory;

    #endregion

    #region Methods

    public override void InstallBindings()
    {
        Container.Bind<LevelFactory>()
            .FromInstance(_levelFactory)
            .AsSingle();
    }

    #endregion
}