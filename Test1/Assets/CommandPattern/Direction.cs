using System;
using UnityEngine;

namespace CommandPattern
{
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
        
        public static Direction ConvertVectorToDirection(Vector2 vector)
        {
            return vector switch
            {
                _ when vector == Vector2.up => Direction.Up,
                _ when vector == Vector2.down => Direction.Down,
                _ when vector == Vector2.left => Direction.Left,
                _ when vector == Vector2.right => Direction.Right,
                _ => Direction.Null
            };
        }

    }
}
