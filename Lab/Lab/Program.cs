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
            Console.WriteLine(new Program().SayHello("tseng"));

            Console.WriteLine("3+2=" + new Program().AplusB(3, 2).ToString());

            Console.ReadKey();
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

    //測試SayHello結果符合預期:Hello +輸入字串

    //測試APlusB結果符合預期:a+b

    //測試物件符合預期

    //測試集合符合預期

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
