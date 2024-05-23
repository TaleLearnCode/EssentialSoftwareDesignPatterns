namespace Decorator;

// Decorator base class
public class CarDecorator(ICar car) : ICar
{
	protected ICar _car = car;

	public virtual void Assemble() => _car.Assemble();
}