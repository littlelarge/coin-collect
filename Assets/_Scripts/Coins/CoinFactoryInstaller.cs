using UnityEngine;
using Zenject;

public class CoinFactoryInstaller : MonoInstaller
{
    [SerializeField] private CoinFactory _coinFactory;

    public override void InstallBindings()
    {
        Container.Bind<CoinFactory>()
            .FromInstance(_coinFactory)
            .AsSingle();
    }
}