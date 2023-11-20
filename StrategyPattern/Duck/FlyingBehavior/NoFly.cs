using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Duck.FlyingBehavior
{
    internal class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly");
        }
    }
}
