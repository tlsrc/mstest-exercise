using System;

namespace GameOfLifeEngine
{
    public abstract class BaseCell
    {
        protected readonly int X;
        protected readonly int Y;

        protected BaseCell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract BaseCell Evolve(int numberOfAliveNeighbors);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var otherCell = (BaseCell) obj;
            return otherCell.X == X && otherCell.Y == Y;

        }

        public override int GetHashCode()
        {
            return X;
        }

        public override string ToString()
        {
            return String.Format("cell at ({0},{1})", X, Y);
        }
    }
}