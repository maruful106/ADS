using StrategyPattern.Interfaces;
using StrategyPattern.Services;
using StrategyPattern;
using StrategyPattern.Duck;
using StrategyPattern.Duck.FlyingBehavior;

internal class Program
{
    /// <summary>
    /// The Strategy Pattern is a behavioral design pattern that defines a family of algorithms, encapsulates each algorithm, 
    /// and makes them interchangeable. It allows a client to choose an algorithm from a family of algorithms at runtime, 
    /// and it lets the algorithm vary independently from clients that use it.
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        //// Client chooses a strategy at runtime
        //IStrategy strategyA = new ConcreteStrategyA();
        //IStrategy strategyB = new ConcreteStrategyB();

        //Context context = new Context(strategyA);
        //context.ExecuteStrategy();

        //// Switching to another strategy dynamically
        //context.SetStrategy(strategyB);
        //context.ExecuteStrategy();


        Duck duck = new WildDuck();
        duck.SetFlyBehavior(new NoFly());
        duck.Flying();
    }
}