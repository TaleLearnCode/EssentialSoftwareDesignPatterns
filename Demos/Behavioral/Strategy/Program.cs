decimal originalPrice = 100.0m;

PriceCalculator calculator = new PriceCalculator(new NoDiscount());
decimal noDiscountPrice = calculator.CalculatePrice(originalPrice);
Console.WriteLine($"Original Price: {originalPrice}, Price with No Discount: {noDiscountPrice}");

calculator.SetDiscountStrategy(new SeasonalDiscount());
decimal seasonalDiscountPrice = calculator.CalculatePrice(originalPrice);
Console.WriteLine($"Original Price: {originalPrice}, Price with Seasonal Discount: {seasonalDiscountPrice}");

calculator.SetDiscountStrategy(new LoyaltyDiscount());
decimal loyaltyDiscountPrice = calculator.CalculatePrice(originalPrice);
Console.WriteLine($"Original Price: {originalPrice}, Price with Loyalty Discount: {loyaltyDiscountPrice}");