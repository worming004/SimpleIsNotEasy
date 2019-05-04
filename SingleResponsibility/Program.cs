using Microsoft.Extensions.DependencyInjection;
using System;

namespace SingleResponsibility
{
	class Program
	{
		static void Main(string[] args)
		{
			var provider = initDependencyInjection();
            var readAndWrite = provider.GetService<IReadAndWrite>();
            readAndWrite.ReadAndWrite();
		}

		private static ServiceProvider initDependencyInjection()
		{
			var provider = new ServiceCollection()
				.AddTransient<IReader, Reader>()
				.AddTransient<IWritter, Writter>()
				.AddTransient<IReadAndWrite, ReadWriteComposition>()
				.BuildServiceProvider();
            return provider;
		}
	}
}
