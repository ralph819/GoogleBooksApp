using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace GoogleBookApp.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class BookPagesTests
    {
        IApp app;
        Platform platform;

        public BookPagesTests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void Search_Book_Results()
        {
            //app.Repl();
            string searchEntryId = "QueryText";
            string searchButtonId = "SearchButton";
            //AppResult[] results = app.WaitForElement(c => c.Marked("Search"));
            //Search Label
            app.WaitForElement(c => c.Marked("SearchLabel"));
            app.Screenshot("Home Screen");
            
            //QueryEntry
            app.ClearText(c => c.Marked(searchEntryId));
            app.EnterText(c=>c.Marked(searchEntryId), "cats");
            app.Screenshot("Search Query Text Typed");

            //Book Results
            app.Tap(c => c.Marked(searchButtonId));
            app.WaitForElement(c => c.Text("Title: Cats"));
            app.Screenshot("Books Result");
            //Assert.IsTrue(results.Any());
        }

        [Test]
        public void Scroll_Load_More_Results()
        {
            Search_Book_Results();
            
            app.ScrollDown(strategy: ScrollStrategy.Gesture);
            app.Screenshot("Scrolled Down 1");

            app.ScrollDown(strategy: ScrollStrategy.Gesture);
            app.Screenshot("Scrolled Down 2");

            //app.Repl();
        }
    }
}
