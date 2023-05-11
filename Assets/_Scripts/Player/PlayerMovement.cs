using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    #region Variables

    private NavMeshAgent _agent;

    #endregion

    #region UnityMethods

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    #endregion

    #region Methods

    public void MoveTo(Vector3 position)
    {
        _agent.SetDestination(position);
    }

    #endregion
}
