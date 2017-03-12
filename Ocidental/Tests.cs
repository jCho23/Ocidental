using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Ocidental
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("bt_rightmenu");
			app.Screenshot("Let's start by Tapping on the User Icon");
			Thread.Sleep(8000);
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			app.Tap("OS NOSSOS SEGUROS");
			app.Screenshot("Then, we Tapped on 'OS NOSSOS SEGUROS'");

			app.Tap("Acidentes Pessoais");
			app.Screenshot("Next, we Tapped on 'Acidentes Pessoais'");

			Thread.Sleep(8000);
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			app.Tap("Médis");
			app.Screenshot("Then, We Tapped on 'Médis'");

			Thread.Sleep(8000);
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			Thread.Sleep(8000);
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button to go back to Main Menu");

			app.Tap("SIMULADOR HOMIN");
			app.Screenshot("Then, we Tapped on 'SIMULADOR HOMIN'");
			Thread.Sleep(8000);

			app.Back();
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			app.Tap("CONTACTOS");
			app.Screenshot("Last, we Tapped on 'CONTACTOS'");
		}

	}
}
