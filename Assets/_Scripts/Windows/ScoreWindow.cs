using System;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreWindow : WindowsCore
{
    private int _score;
    
    public TextMeshProUGUI _textMeshPro;

    private void Start()
    {
        UpdateUI();
    }

    public void IncreaseScore(int value)
    {
        _score += value;
        
        UpdateUI();
    }

    private void UpdateUI()
    {
        _textMeshPro.text = _score.ToString();
    }
}