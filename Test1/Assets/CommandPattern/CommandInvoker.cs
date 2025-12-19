using System.Collections.Generic;

namespace CommandPattern
{
    public class CommandInvoker
    {
        private readonly Stack<ICommand> lastCommands = new Stack<ICommand>();

        public void DoCommand(ICommand command)
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
}
