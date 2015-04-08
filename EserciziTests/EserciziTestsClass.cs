using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using NUnit.Framework;
using Esercizi;


namespace EserciziTests
{
    [TestFixture]
    public class EserciziTestsClass
    {
        [Test]
        public void Check2And3MultiplesLessThen10()
        {
            int[] vect=new int[2]{2,3};
            var sut = new Esercizi.Esercizi();
            Assert.AreEqual(sut.SommaMultipliNnumeriMinoriDi(vect, 10),38);

        }

        [Test]
        public void CheckVectorOf5NumsForEachPossibleSeed()
        {

        }
    }
}
