namespace Liskov
{
    public class ValidateForBelgium : IValidatePerson
    {
        public void Validate(Person p)
        {
            if (p.Age < 18)
            {
                throw new InvalidAgeException();
            }

        }
    }
}
