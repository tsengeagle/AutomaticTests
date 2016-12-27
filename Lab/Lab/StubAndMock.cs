using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lab
{
    public class StubAndMock
    {
        //2.依賴注入，由呼叫端決定依賴實作

        internal void DoSomething()
        {
            //1.抽離依賴
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

        //4.測試案例中注入偽造的依賴類別
        [TestMethod]
        public void SUT_Behavior_HandMadeFakeObject()
        {

        }
    }

    public class MyLog
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    //3.偽造依賴類別
}