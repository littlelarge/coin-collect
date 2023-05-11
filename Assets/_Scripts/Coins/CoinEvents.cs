using System;
using UnityEngine;
using UnityEngine.Events;
using Zenject;

public class CoinEvents : MonoBehaviour
{
    #region Events

    [HideInInspector] public UnityEvent OnCollect = new UnityEvent();
    
    private CoinFactory _coinFactory;
    private WindowsHandler _windowsHandler;
    private Timer _timer;

    #endregion

    #region Constructors

    [Inject]
    private void Construct(CoinFactory coinFactory, WindowsHandler windowsHandler, Timer timer)
    {
        _coinFactory = coinFactory;
        _windowsHandler = windowsHandler;
        _timer = timer;
    }

    #endregion

    #region UnityMethods

    private void Start()
    {
        OnCollect.AddListener(AddTime);
        OnCollect.AddListener(SelfDestruction);
        OnCollect.AddListener(CreateNewCoin);
        OnCollect.AddListener(IncreaseScoreUI);
        OnCollect.AddListener(MakeExplosion);
    }

    #endregion

    #region Methods

    private void AddTime()
    {
        _timer.AddTime(5f);
    }

    private void SelfDestruction()
    {
        Destroy(gameObject);
    }

    private void CreateNewCoin()
    {
        _coinFactory.Create();
    }

    private void IncreaseScoreUI()
    {
        _windowsHandler.Windows.Score.IncreaseScore(1);
    }

    private void MakeExplosion()
    {
        Instantiate(
            Resources.Load<ParticleSystem>($"VFX/Explosion"), transform.position, Quaternion.identity, null);
    }

    #endregion
    
}