using UnityEngine;
using Zenject;

public class GameGlobalEventsInstaller : MonoInstaller
{
    [SerializeField] private GameGlobalEvents _gameGlobalEvents;
    
    public override void InstallBindings()
    {
        Container.Bind<GameGlobalEvents>()
            .FromInstance(_gameGlobalEvents)
            .AsSingle();
    }
}