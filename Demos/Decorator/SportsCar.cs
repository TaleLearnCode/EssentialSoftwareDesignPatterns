namespace Decorator;

// Concreate decorator adding functionality to the core component
public class SportsCar(ICar car) : CarDecorator(car)
{
	public override void Assemble()
	{
		base.Assemble();
		Console.WriteLine("Adding features of Sports Car.");
	}
}