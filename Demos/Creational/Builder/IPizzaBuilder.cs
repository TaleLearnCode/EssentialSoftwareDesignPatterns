namespace Builder;

// Builder Interface
public interface IPizzaBuilder
{
	void BuildDough();
	void BuildSauce();
	void BuildTopping();
	Pizza GetPizza();
}