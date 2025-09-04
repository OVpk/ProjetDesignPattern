using UnityEngine;

public static class DirectionTool
{
    public enum Direction
    {
        Null,
        Up,
        Down,
        Left,
        Right
    }

    public static Vector2 ConvertDirectionToVector(Direction direction)
    {
        return direction switch
        {
            Direction.Up => Vector2.up,
            Direction.Down => Vector2.down,
            Direction.Left => Vector2.left,
            Direction.Right => Vector2.right,
            Direction.Null => Vector2.zero
        };
    }
    
    public static Direction ConvertVectorToDirection(Vector2 direction)
    {
        direction = direction.normalized;
        switch (direction.x)
        {
            case 1 : return Direction.Right; break;
            case -1 : return Direction.Left; break;
        }
        switch (direction.y)
        {
            case 1 : return Direction.Up; break;
            case -1 : return Direction.Down; break;
        }
        return Direction.Null;
    }
}
