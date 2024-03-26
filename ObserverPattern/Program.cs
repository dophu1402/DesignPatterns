using ObserverPattern.ObserverPattern;

var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);

subject.SomeBusinessLogic();

subject.Detach(observerB);

subject.SomeBusinessLogic();
