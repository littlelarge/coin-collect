using UnityEngine;
using Zenject;

public class WindowsHandlerInstaller : MonoInstaller
{
    [SerializeField] private WindowsHandler _windowsHandler;
    
    public override void InstallBindings()
    {
        Container.Bind<WindowsHandler>()
            .FromInstance(_windowsHandler)
            .AsSingle();
    }
}