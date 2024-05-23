using Decorator;

BasicDemonstration();
PerformanceDemonstration();

static void BasicDemonstration()
{

	// Creating a basic car
	ICar basicCar = new BasicCar();
	basicCar.Assemble();
	Console.WriteLine();

	// Decorating basic car with sports car features
	ICar sportsCar = new SportsCar(basicCar);
	sportsCar.Assemble();
	Console.WriteLine();

	// Decorating basic car with luxury car features
	ICar luxuryCar = new LuxuryCar(basicCar);
	luxuryCar.Assemble();
	Console.WriteLine();

	// Decorating basic car with both sports and luxury car features
	ICar sportsLuxuryCar = new LuxuryCar(new SportsCar(basicCar));
	sportsLuxuryCar.Assemble();

}

static void PerformanceDemonstration()
{

	// Creating a basic car
	BasicCar basicCar = new();
	basicCar.Assemble();
	Console.WriteLine();

	// Decorating basic car with sports car features
	SportsCar sportsCar = new(basicCar);
	sportsCar.Assemble();
	Console.WriteLine();

	// Decorating basic car with luxury car features
	LuxuryCar luxuryCar = new(basicCar);
	luxuryCar.Assemble();
	Console.WriteLine();

	// Decorating basic car with sports and luxury car features
	LuxuryCar sportsLuxuryCar = new(new SportsCar(basicCar));
	sportsLuxuryCar.Assemble();

}