using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Lab
{
    public class StubAndMock
    {
        private MyLog _logger;

        public StubAndMock()
        {
            _logger = new MyLog();
        }

        //public StubAndMock(MyLog logger)
        //{
        //    _logger = logger;
        //}

        internal void DoSomething()
        {
            _logger.WriteMessage("執行到此");
        }
    }

    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class StubAndMockTests
    {
        [Ignore]
        [TestMethod]
        public void SUT_Behavior_AssertInteractWithDependencies()
        {
            //arrange

            //act   

            //assert??? <----如何確認DoSomething這個method真的有寫log?

        }

        [TestMethod]
        public void SUT_Behavior_UseMockToSimulateDependencies()
        {
            //arrange

            //act

            //assert

        }
    }

    public class MyLog
    {
        public virtual void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}