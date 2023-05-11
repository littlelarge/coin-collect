using UnityEngine;

public class Player : MonoBehaviour
{
    #region Variables

    public PlayerInput Input { get; private set; }
    public PlayerMovement Movement { get; private set; }

    #endregion

    #region UnityMethods

    private void Awake()
    {
        Input = GetComponent<PlayerInput>();
        Movement = GetComponent<PlayerMovement>();
    }

    #endregion

    #region Methods

    #endregion
}
