using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieApplication;

namespace MovieAppUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Movie movie = new Movie("Blah", "Blah", "Blah", "Blah");
            Program.AddMovie();

        }
    }
}
