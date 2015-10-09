using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
    public class SpaceGrid2D
    {
        Cell[,] cells;
        Coordinates offset;
        int width;
        int height;

        public SpaceGrid2D()
        {
            Resize(0, 0, Coordinates.Zero);
        }

        public SpaceGrid2D(int width, int height)
        {
            Resize(width, height, Coordinates.Zero);
        }

        public SpaceGrid2D(int width, int height, Coordinates offset)
        {
            Resize(width, height, offset);
        }

        public void Resize(int width, int height, Coordinates offset)
        {
            Cell[,] ouldCells = cells;
            cells = new Cell[width, height];
            
            // copy over ould cells
            // use array.copy but we need to copy line by line

            // fix ould cell coordinates

            // init missing cells
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkAxis(Axis axis)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkAxis(Axis axis, Coordinates start)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkAxis(Axis axis, Coordinates start, Coordinates end)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkNeighbours(Coordinates pos, int distance)
        {
            throw new NotImplementedException();
        }
    }

    public enum Axis
    {
        X,
        Y
    }

    public struct Coordinates
    {
        public static readonly Coordinates Zero = new Coordinates(0, 0);

        public int X;
        public int Y;

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Coordinates operator +(Coordinates lhs, Coordinates rhs)
        {
            return new Coordinates(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        public static Coordinates operator -(Coordinates lhs, Coordinates rhs)
        {
            return new Coordinates(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        public static Coordinates operator *(Coordinates lhs, Coordinates rhs)
        {
            return new Coordinates(lhs.X * rhs.X, lhs.Y * rhs.Y);
        }

        public static Coordinates operator /(Coordinates lhs, Coordinates rhs)
        {
            return new Coordinates(lhs.X / rhs.X, lhs.Y / rhs.Y);
        }

        public static Coordinates operator %(Coordinates lhs, Coordinates rhs)
        {
            return new Coordinates(lhs.X % rhs.X, lhs.Y % rhs.Y);
        }
    }

    public class Cell
    {
        Coordinates position;
        public Coordinates Position { get { return position; } }

        public int Distance(Cell cell )
        {
            throw new NotImplementedException();
        }
    }
}
