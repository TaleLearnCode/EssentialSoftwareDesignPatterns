// The client code
using ObserverPattern;

var subject = new ConcreteSubject();
var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);

subject.State = 0;
subject.Notify();

subject.State = 2;
subject.Notify();

subject.Detach(observerB);

subject.State = 3;
subject.Notify();