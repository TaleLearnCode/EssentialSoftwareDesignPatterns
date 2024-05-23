namespace ObserverPattern;

// Concrete Observer A
public class ConcreteObserverA : IObserver
{
	public void Update(ISubject subject)
	{
		if (subject is ConcreteSubject { State: < 3 })
		{
			Console.WriteLine("ConcreteObserverA: Reacted to the event.");
		}
	}
}