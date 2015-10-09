using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
    public class SpaceGrid3D
    {


        public enum Axis
        {
            X,
            Y,
            Z
        }

        public struct Coordinates
        {
            public static readonly Coordinates Zero = new Coordinates(0, 0, 0);

            public int X;
            public int Y;
            public int Z;

            public Coordinates(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public static Coordinates operator +(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
            }

            public static Coordinates operator -(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
            }

            public static Coordinates operator *(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z);
            }

            public static Coordinates operator /(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z);
            }

            public static Coordinates operator %(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.X % rhs.X, lhs.Y % rhs.Y, lhs.Z % rhs.Z);
            }
        }

        public class Cell
        {
            Coordinates position;
            public Coordinates Position { get { return position; } }

            public int Distance(Cell cell)
            {
                throw new NotImplementedException();
            }
        }
    }


}
