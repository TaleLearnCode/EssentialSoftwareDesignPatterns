namespace Factory;

public static class AnimalFactory
{
	public static Animal CreateAnimal(AnimalType animalType)
		=> animalType switch
		{
			AnimalType.Dog => new Dog(),
			AnimalType.Cat => new Cat(),
			_ => throw new ArgumentException("Invalid animal type."),
		};
}