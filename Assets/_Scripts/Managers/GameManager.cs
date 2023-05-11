using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private int _coinsToWin = 10;
    [SerializeField] private float _startTime = 15f;

    [Header("Additionally")]
    
    [SerializeField] private float _timeForAdd = 5f;
    
    private WindowsHandler _windowsHandler;

    public int CoinsToWin
    {
        get { return _coinsToWin; }
    }

    public float StartTime
    {
        get { return _startTime; }
    }

    public float TimeForAdd
    {
        get { return _timeForAdd; }
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