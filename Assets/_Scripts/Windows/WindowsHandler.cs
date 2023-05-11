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
        public ScoreWindow ScoreWindow;
    }
}