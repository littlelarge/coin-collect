using System;
using UnityEngine;

public class WindowsHandler : MonoBehaviour
{
    [SerializeField] private WindowsPreset _windows;
    
    public WindowsPreset Windows
    {
        get { return _windows; }
    }

    [Serializable]
    public struct WindowsPreset
    {
        public CompleteWindow Complete;
        public FailWindow Fail;
        public ScoreWindow Score;
        public TimerWindow Timer;
    }
}