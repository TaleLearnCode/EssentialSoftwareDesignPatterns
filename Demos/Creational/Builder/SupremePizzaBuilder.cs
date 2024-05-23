namespace Builder;

public class SupremePizzaBuilder : IPizzaBuilder
{

	private readonly Pizza _pizza = new();

	public void BuildDough() => _pizza.Crust = "Garlic Epic Stuffed Crust";

	public void BuildSauce() => _pizza.Sauce = "Original Marinara";

	public void BuildTopping() => _pizza.Topping = ["Pepperoni", "Canadian Bacon", "Spicy Italian Sausage", "Mushrooms", "Green Peppers", "Green Olives"];

	public Pizza GetPizza() => _pizza;

}