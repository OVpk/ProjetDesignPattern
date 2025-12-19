using UnityEngine;

namespace CommandPattern
{
    public class MovementCommand : ICommand
    {
        private readonly DirectionTool.Direction direction;
    
        public MovementCommand(Vector2 direction)
        {
            this.direction = DirectionTool.ConvertVectorToDirection(direction);
        }

        public bool Execute()
        {
            if (direction == DirectionTool.Direction.Null)
                return false;
            Vector2 directionToMove = DirectionTool.ConvertDirectionToVector(direction);
            PlayerController.Instance.Move(directionToMove);
            return true;
        }

        public void Undo()
        {
            Vector2 directionToMove = DirectionTool.ConvertDirectionToVector(direction);
            directionToMove = -directionToMove;
            PlayerController.Instance.Move(directionToMove);
        }
    }
}
