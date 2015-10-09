using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
    public class SpaceHex
    {
        public IEnumerator<Cell> WalkAxis(AxisQR axis)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkAxis(AxisQR axis, Coordinates start)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkAxis(AxisQR axis, Coordinates start, Coordinates end)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkAxis(AxisIJK axis)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkAxis(AxisIJK axis, Coordinates start)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkAxis(AxisIJK axis, Coordinates start, Coordinates end)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Cell> WalkNeighbours(Coordinates pos, int distance)
        {
            throw new NotImplementedException();
        }

        public enum AxisQR
        {
            I,
            J,
            K
        }

        public enum AxisIJK
        {
            I,
            J,
            K
        }

        public struct Coordinates
        {
            public static readonly Coordinates Zero = new Coordinates(0, 0);

            public int Q;
            public int R;

            public int I { get { return 0; } set { } }
            public int J { get { return 0; } set { } }
            public int K { get { return 0; } set { } }

            public Coordinates(int q, int r)
            {
                Q = q;
                R = r;
            }

            public Coordinates(int i, int j, int k)
            {
                Q = 0;
                R = 0;
            }

            public static Coordinates operator +(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.Q + rhs.Q, lhs.R + rhs.R);
            }

            public static Coordinates operator -(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.Q - rhs.Q, lhs.R - rhs.R);
            }

            public static Coordinates operator *(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.Q * rhs.Q, lhs.R * rhs.R);
            }

            public static Coordinates operator /(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.Q / rhs.Q, lhs.R / rhs.R);
            }

            public static Coordinates operator %(Coordinates lhs, Coordinates rhs)
            {
                return new Coordinates(lhs.Q % rhs.Q, lhs.R % rhs.R);
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
