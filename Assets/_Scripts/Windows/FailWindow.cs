using Zenject;

public class FailWindow : WindowsCore
{
    #region Variables

    private Map _map;
    private GameGlobalEvents _gameGlobalEvents;

    #endregion

    #region Constructors

    [Inject]
    private void Construct(Map map, GameGlobalEvents gameGlobalEvents)
    {
        _map = map;
        _gameGlobalEvents = gameGlobalEvents;
    }

    #endregion

    #region Methods

    public override void Show()
    {
        base.Show();

        _gameGlobalEvents.OnLevelEnd.Invoke();
    }
    
    public void Retry()
    {
        _map.LoadLevel();

        Close();
    }

    #endregion
}