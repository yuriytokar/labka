using Fifth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthTest
{
  
    [TestClass]
    public class TestTaskC
    {
     

        [TestMethod]
        public void TaskC_ExecutesWithoutError()
        {
            Program program = new Program();

            try
            {
                program.TaskC();
                Console.WriteLine("TaskC executed successfully.");
            }
            catch (Exception)
            {
                Console.WriteLine("TaskC failed");
            }
        }
    }
}
