namespace Reader.Entity
{
    public class Tag
    {
        public int Id {get;set;}
        public string Epc {get;set;}
        public ulong LastSeenTime {get;set;}
        public int Antenna {get;set;}
        public string RaceName {get;set;}
    }
}