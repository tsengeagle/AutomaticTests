using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lab
{
    public class StubAndMock
    {
        internal void DoSomething()
        {
            var logger = new MyLog();
            logger.WriteMessage("執行到此");
        }
    }

    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class StubAndMockTests
    {
        [TestMethod]
        public void SUT_Behavior_UseMockToSimulationDependencies()
        {
            //arrange
            var target=new StubAndMock();

            //act   
            target.DoSomething();

            //assert??? <----如何確認DoSomething這個method真的有寫log?
            
        }
    }

    public class MyLog
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}