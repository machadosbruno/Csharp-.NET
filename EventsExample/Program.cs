//The subscriber Model
EventsExample events = new EventsExample();

events.event_OddNumber += new EventsExample.delegate_OddNumber(EventMessage);
events.addition();
Console.ReadLine();

static void EventMessage()
{
    Console.WriteLine("Evente Executed: Odd Number");
}