using System;

namespace GameOfLifeEngine
{
    public class AliveBaseCell : BaseCell
    {
        public AliveBaseCell(int x, int y) : base(x, y)
        {
        }

        public override BaseCell Evolve(int numberOfAliveNeighbors)
        {
            if (numberOfAliveNeighbors == 2) return new AliveBaseCell(X, Y);
            if (numberOfAliveNeighbors == 3) return new AliveBaseCell(X, Y);
            return new DeadBaseCell(X, Y);
        }

        public override string ToString()
        {
            return String.Format("Alive {0}", base.ToString());
        }
    }
}
