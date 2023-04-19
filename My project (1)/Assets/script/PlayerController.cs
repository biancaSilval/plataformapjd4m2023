using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private PlayerInput _playerInput;
    private GameControlls _gameControlls;
    private Vector2 _moveInput;
    private bool _isShooting; 

    private void OnEnable()
    {
       _playerInput.onActionTriggered += OnAction;
    }

    private void OnDisable()
    {
        _playerInput.onActionTriggered -= OnAction;
    }


    // Start is called before the first frame update
    void Start()
    {
        _gameControlls = new GameControlls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnAction(InputAction.CallbackContext playerAct)
    {
        if (playerAct.action.name == _gameControlls.Gameplay.Shoot.name)
        {
            // faz o jogador atirar 

            if (playerAct.started) _isShooting = true;
            if (playerAct.started) _isShooting = false;
        }

        if (playerAct.action.name == _gameControlls.Gameplay.Move.name)
        {
            // faz o jogador se mover 
            _moveInput = playerAct.ReadValue<Vector2>();
            

        }
        
        
        
    }

}

