using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHR.Test
{
    [TestFixture]
    public class ClassTest
    {
        [Test]
           public void TestMenthod()
        {
            //int i;
            //i = 10;
            //string name = "đạt lê";
            //int j = 20;
            //int k = i + j;
            //console.writeline(k);

            int SoNguyen = 50;
            double SoThuc = SoNguyen;
            int SoNguyen2 = SoThuc;
            Console.WriteLine(SoThuc);
        }
    }
}
