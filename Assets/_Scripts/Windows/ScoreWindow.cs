using TMPro;
using Zenject;

public class ScoreWindow : WindowsCore
{
    #region Variables

    private int _score;
    private GameManager _gameManager;
    
    public TextMeshProUGUI _textMeshPro;

    #endregion

    #region Constructors

    [Inject]
    private void Construct(GameManager gameManager)
    {
        _gameManager = gameManager;
    }

    #endregion

    #region UnityMethods

    private void Start()
    {
        UpdateUI();
    }

    #endregion

    #region Methods

    public void IncreaseScore(int value)
    {
        _score += value;
        
        UpdateUI();
    }

    public void Reset()
    {
        _score = 0;

        UpdateUI();
    }

    private void UpdateUI()
    {
        _textMeshPro.text = _score.ToString();

        if (_score == _gameManager.CoinsToWin)
            _gameManager.Win();
    }

    #endregion
}
