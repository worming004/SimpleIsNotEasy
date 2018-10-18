namespace SingleResponsibility
{
	public class ReadWriteTemplate : IReadAndWrite
	{
		private IReader reader;
		private IWritter writter;

		public ReadWriteTemplate(IReader reader, IWritter writter)
		{
			this.reader = reader;
			this.writter = writter;
		}

		public void ReadAndWrite()
		{
			var input = reader.Read();
			writter.Write(input);
		}
	}
}