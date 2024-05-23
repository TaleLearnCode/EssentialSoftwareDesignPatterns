namespace Strategy;

public class PriceCalculator(IDiscountStrategy discountStrategy)
{

	private IDiscountStrategy _discountStrategy = discountStrategy;

	public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
		=> _discountStrategy = discountStrategy;

	public decimal CalculatePrice(decimal price)
		=> _discountStrategy.ApplyDiscount(price);

}