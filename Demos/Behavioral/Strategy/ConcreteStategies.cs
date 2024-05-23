namespace Strategy;

public class NoDiscount : IDiscountStrategy
{
	public decimal ApplyDiscount(decimal price) => price; // No discount applied
}

public class SeasonalDiscount : IDiscountStrategy
{
	public decimal ApplyDiscount(decimal price) => price * 0.9m; // 10% discount
}

public class LoyaltyDiscount : IDiscountStrategy
{
	public decimal ApplyDiscount(decimal price) => price * 0.85m; // 15% discount
}