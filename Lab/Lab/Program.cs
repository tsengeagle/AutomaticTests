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

        internal int AplusB(int a, int b)
        {
            return a + b;
        }

        public override bool Equals(object obj)
        {
            if (obj is Program)
            {
                return true;
            }
            return base.Equals(obj);
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
            var target = new Program();
            var expected = "Hello tseng";
            //act
            var actual = target.SayHello(myName);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_InputTwoNumber_ShouldGetSummary()
        {
            //arrange
            var a = 1;
            var b = 2;
            var expected = 3;
            var target = new Program();

            //act
            var actual = target.AplusB(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ObjectCompare_CreateAnObject_ButWillNeverEqual()
        {
            //arrange
            var expected = new Program();

            //act
            var actual = new Program();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ComplexObject_NeedsToCompareEachProperties()
        {
            //arrange
            var expected = new MyType() { Name = "MyName", Value = 10 };

            //act
            var actual = new MyType() { Name = "MyName", Value = 10 };

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class MyType
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is MyType)
            {
                if (((MyType)obj).Name == Name && ((MyType)obj).Value == Value)
                {
                    return true;
                }
            }
            return base.Equals(obj);
        }
    }
}
