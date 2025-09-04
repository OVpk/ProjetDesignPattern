using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    private Stack<Icommand> lastCommands = new Stack<Icommand>();

    public void DoCommand(Icommand command)
    {
        if (command.Execute())
            lastCommands.Push(command);
    }

    public void UndoCommand()
    {
        if (lastCommands.Count == 0) return;
        lastCommands.Pop().Undo();
    }
}
