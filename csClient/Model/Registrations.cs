
using FluentValidation;

namespace csClient.Model
{
    public class Registrations
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int  Age { get; set; }
        public string Gender { get; set; }
        public string Tag { get; set; }
    }

    public class RegistrationsValidator : AbstractValidator<Registrations>
    {
        public RegistrationsValidator()
        {
            RuleFor(x=>x.FirstName).NotEmpty();
            RuleFor(x=>x.LastName).NotEmpty();
            RuleFor(x=>x.Age).NotEmpty().GreaterThan(0);
            RuleFor(x=>x.Gender).NotEmpty().MaximumLength(1);
        }
    }
}