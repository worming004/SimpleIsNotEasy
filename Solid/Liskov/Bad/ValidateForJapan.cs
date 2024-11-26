using System.IO;
using System.Text.Json;

namespace Liskov
{
    public class ValidateForJapan : IValidatePerson
    {
        public void Validate(Person p)
        {
            if (p.Age < 18)
            {
                throw new InvalidAgeException();
            }
            var jsonPerson = JsonSerializer.Serialize(p);
            File.WriteAllText("person.json", jsonPerson);
        }
    }
}
