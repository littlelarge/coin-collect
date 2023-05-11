using UnityEngine;
using Zenject;

public class LevelFactory : MonoBehaviour
{
    #region Variables
    
    private DiContainer _diContainer;
    private Map _map;

    public Level Level { get; private set; }

    #endregion
    
    #region Constructors

    [Inject]
    private void Construct(DiContainer diContainer, Map map)
    {
        _diContainer = diContainer;
        _map = map;
    }

    #endregion
    
    #region Methods

    public void Create()
    {
        Level = _diContainer.InstantiatePrefabForComponent<Level>(Resources.Load<GameObject>($"Levels/Level_{1}"),
            Vector3.zero, Quaternion.identity, _map.transform);
    }
    
    #endregion
}