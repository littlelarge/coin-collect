using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private int _coinsToWin = 10;
    [SerializeField] private float _startTime = 15f;
    
    private WindowsHandler _windowsHandler;

    public int CoinsToWin
    {
        get { return _coinsToWin; }
    }

    public float StartTime
    {
        get { return _startTime; }
    }
    
    #endregion

    #region Constructors

    [Inject]
    private void Construct(WindowsHandler windowsHandler)
    {
        _windowsHandler = windowsHandler;
    }

    #endregion

    #region Methods

    public void Win()
    {
        _windowsHandler.Windows.Complete.Show();
    }

    public void Lose()
    {
        _windowsHandler.Windows.Fail.Show();
    }
    
    #endregion
}