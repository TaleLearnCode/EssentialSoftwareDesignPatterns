namespace ObserverPattern;

// Observer interface
public interface IObserver
{
	void Update(ISubject subject);
}