using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
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
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

		[Test]
		public void AddItem()
		{
			// Test Accessing ItemPage from ItemList
			app.Tap("HamburgerStack");
			app.Tap("ItemsMenu");
			app.Tap("AddItem");

			// Test adding text to fields of Item
			// Name
			app.Tap("ItemNameEntry");
			app.EnterText("Test Name");
			// BoxNumber
			app.Tap("ItemBoxNumberEntry");
			app.EnterText("1");
			// Desc
			app.Tap("ItemDescEditor");
			app.EnterText("Test Description goes here");
			// Save
			app.Tap("Save Item");
		}

        [Test]
		public void AddBox()
		{
			// Test Accessing ItemPage from ItemList
			app.Tap("HamburgerStack");
			app.Tap("BoxesMenu");
			app.Tap("AddBox");

			// Test adding text to fields of Item
			// Desc
			app.Tap("ItemDescEditor");
			app.EnterText("Test Description goes here");
			// Location
			app.Tap("BoxLocationEntry");
			app.EnterText("Test Location");
			// Save
			app.Tap("Save Item");
		}

		[Test]
		public void AddRoom()
		{
			// Test Accessing ItemPage from ItemList
			app.Tap("HamburgerStack");
			app.Tap("RoomsMenu");
			app.Tap("AddRoom");

			// Test adding text to fields of Item
			// Name
			app.Tap("BoxNameEntry");
			app.EnterText("Test Box");
			// Desc
			app.Tap("ItemDescEditor");
			app.EnterText("Test Description goes here");
			// Save
			app.Tap("Save Item");
		}

		[Test]
		public void HamburgerStackMenu()
		{
			app.Screenshot("First screen.");

			// Test Accessing ItemPage from ItemList
			app.Tap("HamburgerStack");
			app.Tap("ItemsMenu");

			// Test accessing BoxPage from BoxesList
			app.Tap("HamburgerStack");
			app.Tap("BoxesMenu");

			// Test accessing RoomPage from RoomsList
			app.Tap("HamburgerStack");
			app.Tap("RoomsMenu");

			// Test accessing Data Export from HamburgerStack
			app.Tap("HamburgerStack");
			app.Tap("DataExportMenu");

			// Test accessing Settings from HamburgerStack
			app.Tap("HamburgerStack");
			app.Tap("SettingsMenu");
		}

		[Test]
		public void DataExport()
		{
			// Test accessing Data Export from HamburgerStack
			app.Tap("HamburgerStack");
			app.Tap("DataExportMenu");
            app.Tap("DataExport");
		}

		[Test]
		public void CloudSync()
		{
			app.Tap("HamburgerStack");
			app.Tap("SettingsMenu");
            app.Tap("CloudSync");
            app.Tap("CloudSyncToggle");
            app.Tap("ForceSync");
            app.Back();
		}
    }
}
