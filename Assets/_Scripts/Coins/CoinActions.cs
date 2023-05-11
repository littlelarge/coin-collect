using UnityEngine;
using Zenject;

public class CoinActions : MonoBehaviour, ICollectable
{
    #region Variables

    private CoinFactory _coinFactory;
    private WindowsHandler _windowsHandler;

    #endregion

    #region Constructors

    [Inject]
    private void Construct(CoinFactory coinFactory, WindowsHandler windowsHandler)
    {
        _coinFactory = coinFactory;
        _windowsHandler = windowsHandler;
    }

    #endregion

    #region Methods
    
    public void Collect()
    {
        Destroy(gameObject);

        _coinFactory.Create();
        
        _windowsHandler.Windows.ScoreWindow.IncreaseScore(1);

        Instantiate(
            Resources.Load<ParticleSystem>($"VFX/Explosion"), transform.position, Quaternion.identity, null);
    }

    #endregion
}