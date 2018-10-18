public class Person
{
	public string Name;
	public int? Age;
}

public class InvalidPersonException : System.Exception
{
	public InvalidPersonException(Person person) : base($"invalid person: {person.ToString()}")
	{

	}
}

public class DbStore
{
	public void StorePerson(Person person)
	{
		if(string.IsNullOrEmpty(person.Name) || person.Age == null)
		{
			throw new InvalidPersonException(person);
		}
		// Do not do this at home. It's just a quick solution for this example. Prefer dependency injection
		new FakeDb().StorePerson(person);
	}

	// Do not do this at home. It's just a quick solution for this example. Prefer external public class.
	private class FakeDb
	{
		public void StorePerson(Person person)
		{
			// Store in DB here
		}
	}
}