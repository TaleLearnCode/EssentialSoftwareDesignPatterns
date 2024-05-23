namespace Decorator;

// Concrete implementation of the core component
public class BasicCar : ICar
{
	public void Assemble() => Console.WriteLine("Basic Car is assembled.");
}