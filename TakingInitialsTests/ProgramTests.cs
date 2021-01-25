using NUnit.Framework;
using TakingInitials;
using System;
using System.Collections.Generic;
using System.Text;

namespace TakingInitials.Tests
{
    [TestFixture()]
    public class ProgramTests
    {
        [Test()]
        public static void GetNameWithInitialsTest()
        {
            String actualName1 = Program.GetNameWithInitials("Mary Jane Watson");
            Assert.AreEqual("M. J. Watson", actualName1);

            String actualName2 = Program.GetNameWithInitials("Harry Potter");
            Assert.AreEqual("H. Potter", actualName2);

            String actualName3 = Program.GetNameWithInitials("Emilia Isobel Euphemia Rose Clarke");
            Assert.AreEqual("E. I. E. R. Clarke", actualName3);

            String actualName4 = Program.GetNameWithInitials("Sadda Vidda Palanga Pathira Patabandige Andare");
            Assert.AreEqual("S. V. P. P. P. Andare", actualName4);

            String actualName5 = Program.GetNameWithInitials("Dharana");
            Assert.AreEqual("Dharana", actualName5);

        }
    }
}