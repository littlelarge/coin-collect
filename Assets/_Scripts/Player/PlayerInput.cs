using System;
using UnityEngine;
using UnityEngine.Events;
using Zenject;

public class PlayerInput : MonoBehaviour
{
    #region Variables

    private Camera _camera;
    private PlayerFactory _playerFactory;

    #endregion

    #region Constructors

    [Inject]
    private void Construct(PlayerFactory playerFactory)
    {
        _playerFactory = playerFactory;
    }

    #endregion

    #region UnityMethods

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        OnClick();
    }

    #endregion

    #region Methods

    private void OnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Input.mousePosition;
            
            Ray ray = _camera.ScreenPointToRay(mousePos);

            if (Physics.Raycast(ray, out RaycastHit hit, 100))
            {
                Vector3 worldPos = hit.point;

                _playerFactory.Player.Movement.MoveTo(worldPos);
            }
        }
    }

    #endregion
}