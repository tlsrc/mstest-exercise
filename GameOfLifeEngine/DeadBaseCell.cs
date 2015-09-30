using System;

namespace GameOfLifeEngine
{
    public class DeadBaseCell : BaseCell
    {
        public DeadBaseCell(int x, int y) : base(x, y)
        {
        }

        public override BaseCell Evolve(int numberOfAliveNeighbors)
        {
            if(numberOfAliveNeighbors == 3) return new AliveBaseCell(X, Y);
            return new DeadBaseCell(X, Y);
        }

        public override string ToString()
        {
            return String.Format("Dead {0}", base.ToString());
        }
    }
}