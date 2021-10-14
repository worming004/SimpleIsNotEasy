namespace Liskov
{
    public class SaveMongo : ISave
    {
        public void SavePerson(Person p)
        {
            if (p.Age < 0)
                throw new InvalidAgeException();

            // save in mongodb
        }
    }
}