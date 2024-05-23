namespace ObserverPattern;

// Concrete Subject
public class ConcreteSubject : ISubject
{
	public int State { get; set; } = 0;

	private readonly List<IObserver> _observers = [];

	public void Attach(IObserver observer)
	{
		Console.WriteLine("Subject: Attached an observer.");
		_observers.Add(observer);
	}

	public void Detach(IObserver observer)
	{
		_observers.Remove(observer);
		Console.WriteLine("Subject: Detached an observer.");
	}

	public void Notify()
	{
		Console.WriteLine("Subject: Notifying observers...");

		foreach (var observer in _observers)
		{
			observer.Update(this);
		}
	}
}