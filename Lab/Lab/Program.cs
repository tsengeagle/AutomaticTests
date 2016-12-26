using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

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

        //public override bool Equals(object obj)
        //{
        //    if (obj is Program)
        //    {
        //        return true;
        //    }
        //    return base.Equals(obj);
        //}
    }

    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void SayHello_InputMyName_ShouldSayHelloToMe()
        {
            //arrange

            //act
            
            //assert
            
        }

        [TestMethod]
        public void Add_InputTwoNumber_ShouldGetSummary()
        {
            //arrange
            
            //act
            
            //assert
            
        }

        [TestMethod]
        public void ObjectCompare_CreateAnObject_ButWillNeverEqual()
        {
            //arrange

            //act

            //assert

        }

        [TestMethod]
        public void ComplexObject_NeedsToCompareEachProperties()
        {
            //arrange

            //act

            //assert
        }

        [TestMethod]
        public void ComplexObject_UseExpectedObject_ToCompareEachProperties()
        {
            //arrange

            //act

            //assert

        }

        [TestMethod]
        public void ComplexObject_UseExpectedObject_PartialCompare()
        {
            //arrange

            //act

            //assert

        }

        [TestMethod]
        public void CollectionObject_UseCollectionAssert_CompareTwoCollection()
        {
            //arrange

            //act

            //assert

        }

        [TestMethod]
        public void CollectionObject_UseCollectionAssert_PartialCompare()
        {
            //arrange

            //act

            //assert

        }

        [TestMethod]
        public void CollectionObject_UseExpectedObject()
        {
            //arrange
            
            //act
        
            //assert

        }
    }

    public class MyType
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }

    public class AdmCSRACodeTbl
    {
        public string chSecNo { get; set; }
        public string chACode { get; set; }
        public string chACodeName { get; set; }
        public Nullable<short> chValidDay { get; set; }
        public PositionLogs UsageLogs { get; set; }
    }

    public class PositionLogs
    {
        public DateTime DateTime { get; set; }
        public string Location { get; set; }
    }
}
