namespace ObserverPattern;

// Concrete Observer B
public class ConcreteObserverB : IObserver
{
	public void Update(ISubject subject)
	{
		if (subject is ConcreteSubject { State: 0 or >= 2 })
		{
			Console.WriteLine("ConcreteObserverB: Reacted to the event.");
		}
	}
}