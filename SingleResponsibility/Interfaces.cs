namespace SingleResponsibility
{
	public interface IReadAndWrite
	{
		void ReadAndWrite();
	}
	public interface IReader
	{
		string Read();
	}
	public interface IWritter
	{
		void Write(string text);
	}
}