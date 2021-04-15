using System;

namespace DPClientVS.Client.Model
{
    public class Races
    {
        public int Id {get;set;}
        public string Race_Name { get; set; }
        public string Organiser { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Description { get; set; }
        public string Date {get;set;}
    }
}