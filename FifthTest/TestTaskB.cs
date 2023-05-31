using Fifth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FifthTest
{
    [TestClass]

    public class TestTaskB
    {
        private Program program;
        [TestInitialize]
        public void Setup()
        {
            program = new Program();
            program.InitializeData();
        }



        [TestMethod]
       
        public void TaskB_ExecutesWithoutError()
        {
            Program program = new Program();

            program.InitializeData();
            program.TaskB();

            
            Console.WriteLine("TaskB test passed.");
        }
    }
}
