using Fifth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FifthTest
{
    [TestClass]
    public class TestTaskA
    {
        [TestMethod]
        public void TaskA_ExecutesWithoutError()
        {
            Program program = new Program();
            program.InitializeData();
            int minimumAge = 30;

            try
            {
                program.TaskA(minimumAge);
            }
            catch
            {
                Assert.Fail("An exception was thrown.");
            }

            Assert.IsTrue(true);
        }
    }
}
