using System.Collections;
using UnityEngine;
using Zenject;

public class Timer : MonoBehaviour
{
    #region Variables

    private float _targetTime = 15f;
    private float _currentTime = 0f;
    private bool _canTick;
    
    private GameManager _gameManager;
    private WindowsHandler _windowsHandler;

    #endregion

    #region Constructors

    [Inject]
    private void Construct(GameManager gameManager, WindowsHandler windowsHandler)
    {
        _gameManager = gameManager;
        _windowsHandler = windowsHandler;
    }

    #endregion

    #region Methods

    public void Init()
    {
        _targetTime = _gameManager.StartTime;
        _currentTime = _targetTime;
        _canTick = true;
        
        StartCoroutine(TimerRoutine());
    }

    private void UpdateTimerUI()
    {
        _windowsHandler.Windows.Timer.TimerTextMeshPro.text = Mathf.Round(_currentTime).ToString();
    }

    public void AddTime(float time)
    {
        _currentTime = Mathf.Clamp(_currentTime + time,0, _gameManager.StartTime);
    }

    public void StopTimer()
    {
        _canTick = false;
    }
    
    #endregion

    #region Coroutines

    private IEnumerator TimerRoutine()
    {
        while (_currentTime > 0)
        {
            if (!_canTick)
                yield break;
            
            _currentTime -= Time.deltaTime;

            UpdateTimerUI();
            
            yield return null;
        }

        _gameManager.Lose();
    }

    #endregion
}