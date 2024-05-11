using System;
public class EventClass
{
    public delegate void EventDelegate(string message);
    public event EventDelegate MyEvent;
    public string Name { get; set; }
    public void GenerateEvent()
    {
        if (MyEvent != null)
        {
            MyEvent(Name);
        }
    }
}
public class EventHandlerClass
{
    public void HandleEvent(string message)
    {
        Console.WriteLine($"Событие сгенерировано объектом: {message}");
    }
}
public class Program
{
    public static void Main()
    {
        EventClass object1 = new EventClass { Name = "Object 1" };
        EventClass object2 = new EventClass { Name = "Object 2" };

        EventHandlerClass handler = new EventHandlerClass();

        object1.MyEvent += handler.HandleEvent;
        object2.MyEvent += handler.HandleEvent;

        object1.GenerateEvent();
        object2.GenerateEvent();
    }
}
