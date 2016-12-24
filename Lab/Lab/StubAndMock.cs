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

        public StubAndMock(MyLog logger)
        {
            _logger = logger;
        }

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
            var target = new StubAndMock();

            //act   
            target.DoSomething();

            //assert??? <----如何確認DoSomething這個method真的有寫log?

        }

        [TestMethod]
        public void SUT_Behavior_UseMockToSimulateDependencies()
        {
            //arrange
            var mockObject = new Mock<MyLog>();
            //mockObject.Setup(s => s.WriteMessage(It.IsAny<string>()));
            var logger = mockObject.Object;
            var target = new StubAndMock(logger);

            //act
            target.DoSomething();

            //assert
            mockObject.Verify(v => v.WriteMessage(It.IsAny<string>()), Times.Exactly(1));
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