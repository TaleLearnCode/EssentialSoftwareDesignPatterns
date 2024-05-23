namespace Strategy;

public interface IDiscountStrategy
{
	decimal ApplyDiscount(decimal price);
}
