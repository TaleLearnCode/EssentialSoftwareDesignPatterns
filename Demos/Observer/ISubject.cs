﻿namespace ObserverPattern;

// Subject interface
public interface ISubject
{
	void Attach(IObserver observer);
	void Detach(IObserver observer);
	void Notify();
}