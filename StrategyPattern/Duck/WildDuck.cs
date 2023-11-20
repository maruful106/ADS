using StrategyPattern.Duck.FlyingBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Duck
{
    public class WildDuck : Duck
    {
        public WildDuck() : base(new FlyWithWings())
        {
        }
        public void Flying()
        {
            flyBehavior.Fly();
        }
    }
}
