using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private CommandInvoker commandInvoker;
    
    private void Awake()
    {
        commandInvoker = new CommandInvoker();
    }

    public void OnMove(InputValue value)
    {
        commandInvoker.DoCommand(new MovementCommand(value.Get<Vector2>()));
    }

    public void OnUndo(InputValue value)
    {
        commandInvoker.UndoCommand();
    }
}
