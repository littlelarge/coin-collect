using UnityEngine;
using UnityEngine.Events;
using Zenject;

public class GameGlobalEvents : MonoBehaviour
{
    #region Variables
    
    private Timer _timer;
    private WindowsHandler _windowsHandler;

    #endregion
    
    #region Events

    [HideInInspector]
    public UnityEvent OnLevelLoad { get; } = new UnityEvent();
    [HideInInspector]
    public UnityEvent OnLevelEnd { get; } = new UnityEvent();

    #endregion

    #region Constructors

    [Inject]
    private void Construct(Timer timer, WindowsHandler windowsHandler)
    {
        _timer = timer;
        _windowsHandler = windowsHandler;
    }

    #endregion

    #region UnityEvents

    private void Start()
    {
        InitEvents();
    }

    #endregion

    #region Methods

    private void InitEvents()
    {
        // on level load
        
        OnLevelLoad.AddListener(_windowsHandler.Windows.Score.Reset);
        OnLevelLoad.AddListener(_timer.Init);
        
        // on level end

        OnLevelEnd.AddListener(_timer.StopTimer);
    }

    #endregion
}