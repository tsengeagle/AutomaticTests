﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var expected=new Program();

            //act
            var actual=new Program();

            //assert
            Assert.AreNotEqual(expected,actual);

        }
    }
}
