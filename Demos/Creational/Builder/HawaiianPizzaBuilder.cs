namespace Builder;

// Concrete Builder
public class HawaiianPizzaBuilder : IPizzaBuilder
{

	private readonly Pizza _pizza = new();

	public void BuildDough() => _pizza.Crust = "Original";

	public void BuildSauce() => _pizza.Sauce = "Classic Marinara";

	public void BuildTopping() => _pizza.Topping = ["Ham", "Pineapple"];

	public Pizza GetPizza() => _pizza;

}