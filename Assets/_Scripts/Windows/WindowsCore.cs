using UnityEngine;

public abstract class WindowsCore : MonoBehaviour
{
    #region Methods

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
    
    #endregion
}