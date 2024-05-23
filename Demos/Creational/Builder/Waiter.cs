namespace Builder;

// Director
public class Waiter(IPizzaBuilder pizzaBuilder)
{
	private readonly IPizzaBuilder _pizzaBuilder = pizzaBuilder;

	public void ConstructPizza()
	{
		_pizzaBuilder.BuildDough();
		_pizzaBuilder.BuildSauce();
		_pizzaBuilder.BuildTopping();
	}

	public Pizza GetPizza() => _pizzaBuilder.GetPizza();

}
