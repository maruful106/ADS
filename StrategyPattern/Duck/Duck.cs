using StrategyPattern.Duck.FlyingBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Duck
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;

        public Duck(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetFlyBehavior(IFlyBehavior newFlyBehavior)
        {
            this.flyBehavior = newFlyBehavior;
        }
        public void Flying()
        {
            flyBehavior.Fly();
        }
    }
}
