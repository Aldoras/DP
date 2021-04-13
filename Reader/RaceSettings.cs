using System;

namespace Reader
{
    public class RaceSettings
    {
        public DateTimeOffset Start {get;set;}
        public TimeSpan Duration {get;set;}
        public int Laps {get;set;}
        public TimeSpan LapTime {get;set;}
        public string Name {get;set;}
        public string EPCPrefix {get;set;}
    }
}