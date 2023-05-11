using TMPro;
using UnityEngine;

public class TimerWindow : WindowsCore
{
    [SerializeField] private TextMeshProUGUI _timerTextMeshPro;
    
    public TextMeshProUGUI TimerTextMeshPro
    {
        get { return _timerTextMeshPro; }
    }
}