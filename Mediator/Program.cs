using System;
using static Mediator.AlarmForMediator;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            AlarmMediator alarmMediator = new AlarmMediator(new CoffeePot(), new Sprinkler());
            CalendarMediator calendarMediator = new CalendarMediator(new CoffeePot(), new Sprinkler());

            Alarm alarm = new Alarm(alarmMediator);
            Calendar calendar = new Calendar(calendarMediator);

            calendar.OnEvent();
            alarm.OnEvent();

            Console.ReadLine();
        }
    }
}