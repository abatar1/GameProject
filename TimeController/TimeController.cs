using System;
using System.Collections.Generic;
using System.Timers;

namespace GameProject
{
    public class TimeController : ITimeController
    {
        private Dictionary<string, long> timers;
        private Timer iTimer;

        public void Timer()
        {
            iTimer = new Timer(5);
            iTimer.Elapsed += OnTimedEvent;
        }

        public void AddCastTimer(string castName, long time) => timers.Add(castName, time);

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            foreach (var timer in timers)
            {
                if (timer.Value - 5 <= 0)
                {
                    timers.Remove(timer.Key);
                    //тут же мы должны как-то сообщить Character, что действие заклинания закончилось
                    //после чего в Character мы вызовем 
                }
            }
            Timer();
        }
    }
}
