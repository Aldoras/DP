using System;

namespace API.Entities
{
    public class AppUser
    {
        public int Id {get;set;}
        public string Email {get;set;}
        public string  UserName { get; set; }
        public byte[] PasswordHash {get;set;}
        public byte[] PasswordSalt { get; set; }
        public DateTime BirthDate { get; set; }
        public string State {get;set;}
        public string Team { get; set; }
        public string Sex  {get;set;}
    }
}