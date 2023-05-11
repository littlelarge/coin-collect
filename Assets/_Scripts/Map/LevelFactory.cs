using UnityEngine;
using Zenject;

public class LevelFactory : MonoBehaviour
{
    #region Variables
    
    private DiContainer _diContainer;

    public Level Level { get; private set; }

    #endregion
    
    #region Constructors

    [Inject]
    private void Construct(DiContainer diContainer)
    {
        _diContainer = diContainer;
    }

    #endregion
    
    #region Methods

    public void Create(Transform parent)
    {
        Level = _diContainer.InstantiatePrefabForComponent<Level>(Resources.Load<GameObject>($"Levels/Level_{1}"),
            Vector3.zero, Quaternion.identity, parent);
    }
    
    #endregion
}