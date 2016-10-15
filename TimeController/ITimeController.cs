using System;
using System.Collections.Generic;
using System.Timers;

namespace GameProject
{
    public interface ITimeController
    {
        void AddCastTimer(string castName, long time);
        void OnTimedEvent(Object source, ElapsedEventArgs e);
    }
}
