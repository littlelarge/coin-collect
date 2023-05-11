using UnityEngine;

public abstract class WindowsCore : MonoBehaviour
{
    #region Methods

    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public virtual void Close()
    {
        gameObject.SetActive(false);
    }
    
    #endregion
}