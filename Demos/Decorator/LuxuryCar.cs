namespace Decorator;

// Another concreate decorator adding more functionality
public class LuxuryCar(ICar car) : CarDecorator(car)
{
	public override void Assemble()
	{
		base.Assemble();
		Console.WriteLine("Adding features of Luxury Car.");
	}
}