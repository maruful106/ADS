using DependencyInjection;
using System.Reflection;

internal class Program
{
    /// <summary>
    /// Dependency Injection(DI) is a software design pattern that deals with how components(objects or services) obtain their dependencies.
    /// In simple terms, it is a technique in which the dependencies of a component are provided to it rather than the component creating 
    /// or managing those dependencies itself.The primary goal of dependency injection is to achieve loose coupling between components, 
    /// making the system more modular, maintainable, and testable.
    /// 
    /// Injection Types:

    /// Constructor Injection:
    ///     Dependencies are injected through the constructor of the dependent class.
    /// Setter Injection:
    ///     Dependencies are injected through setter methods of the dependent class.
    /// Method Injection:
    ///     Dependencies are injected through methods of the dependent class.
    ///     
    /// Inversion of Control (IoC):
    ///     Dependency Injection is often associated with Inversion of Control.In IoC, the control over the flow of the program is inverted.
    ///     Instead of a component controlling the creation and management of its dependencies, the responsibility is moved to an external 
    ///     entity (the DI Container).
    /// Loose Coupling:
    ///     Dependency Injection promotes loose coupling between components.Components don't need to be aware of how their dependencies are 
    ///     created or managed; they only rely on interfaces or abstract types.
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        ILogger logger = new Logger();
        CustomerService customerService = new CustomerService(logger);
        customerService.AddCustomer("this is a customer.");
    }
}