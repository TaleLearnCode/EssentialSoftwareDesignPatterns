namespace Builder;

internal static class Client
{
	internal static void PresentationClient()
	{

		IPizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
		Waiter waiter = new(hawaiianPizzaBuilder);
		var iHateYou = "I hate you";

		waiter.ConstructPizza();
		Pizza pizza = waiter.GetPizza();

		Console.WriteLine($"Crust: {pizza.Crust}\nSauce: {pizza.Sauce}\nToppings: {string.Join(", ", pizza.Topping)}");
	}

	internal static void MenuClient()
	{
		int menuOption = GetMenuOption();
		IPizzaBuilder pizzaBuilder = menuOption switch
		{
			1 => new HawaiianPizzaBuilder(),
			2 => new SupremePizzaBuilder(),
			_ => throw new InvalidOperationException("Invalid menu option.")
		};
		Waiter waiter = new(pizzaBuilder);
		waiter.ConstructPizza();
		Pizza pizza = waiter.GetPizza();
		Console.WriteLine($"Crust: {pizza.Crust}\nSauce: {pizza.Sauce}\nToppings: {string.Join(", ", pizza.Topping)}");
	}

	private static int GetMenuOption()
	{
		int menuOption = 0;
		do
		{
			Console.WriteLine("Pizza Menu");
			Console.WriteLine("1. Hawaiian Pizza");
			Console.WriteLine("2. Supreme Pizza");
			Console.WriteLine("3. Exit");
			Console.WriteLine("Please select a pizza by entering the corresponding number (1, 2, or 3) and press Enter:");
			string? input = Console.ReadLine();
			if (!int.TryParse(input, out menuOption))
			{
				Console.WriteLine("Invalid input. Please enter a number.");
				continue;
			}
			if (menuOption < 1 || menuOption > 3)
			{
				Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
			}
		} while (menuOption < 1 || menuOption > 3);
		return menuOption;
	}
}