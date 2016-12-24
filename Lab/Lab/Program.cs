using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public string SayHello(string myName)
        {
            return "Hello " + myName;
        }
    }

    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void SayHello_InputMyName_ShouldSayHelloToMe()
        {
            //arrange
            var myName = "tseng";
            var target=new Program();
            
            //act
            var actual=target.SayHello(myName);
            
            //assert
            Assert.AreEqual("Hello tseng",actual);
        }
    }
}
