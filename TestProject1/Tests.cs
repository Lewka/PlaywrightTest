using System;
using System.Threading.Tasks;
using NUnit.Framework;
using PlaywrightSharp;

namespace TestProject1
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public async Task Test1()
		{
			Console.WriteLine("Installing playwright");
			await Playwright.InstallAsync();
			Console.WriteLine("Creating playwright");
			var playwright = await Playwright.CreateAsync();
		}
	}
}