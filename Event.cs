using System;

namespace VisualProgramming
{
    internal delegate void EventExample();
    class Event
    {
        public static Event Singelton = new Event();

        public event EventExample ExampleEvent;
        public void FireEvent()
        {
            ExampleEvent.Invoke();
        }
    }
}
