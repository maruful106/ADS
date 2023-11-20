using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Duck.FlyingBehavior
{
    internal class FlyWithJetPower : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with Jet Power");
        }
    }
}
