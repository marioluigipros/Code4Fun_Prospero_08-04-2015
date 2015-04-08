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
            Assert.AreEqual(sut.MakeSumOfMultiples(vect, 10),38);

        }

        public void Check3And5MultiplesLessThen1000()
        {
            int[] vect = new int[2] { 3, 5 };
            var sut = new Esercizi.Esercizi();
            Assert.AreEqual(sut.MakeSumOfMultiples(vect, 1000), Sum3And5MultiplesLessThen1000Direct());

        }

        private int Sum3And5MultiplesLessThen1000Direct()
        {
            int x = 3;
            int y = 5;
            int totale = 0;

            while (x < 1000)
            {
                totale += x;
                x += 3;
            }

            while (y < 1000)
            {
                totale += y;
                y += 5;
            }

            return totale;

        }

        [Test]
        public void CheckVectorOf5NumsForEachPossibleSeed()
        {
            bool failure = false;
            var sut = new Esercizi.Esercizi();
            HashSet<string> StringSet = new HashSet<string>();            

            sut.FakeSeed = 1;
            int[] vector = sut.CompilaVettore(5);
            StringSet.Add(StringFromVector(vector));
            if (!CheckNumbersAreAllAndDistinct(vector))
                failure = true;            

            sut.FakeSeed = 2;
            vector = sut.CompilaVettore(5);
            StringSet.Add(StringFromVector(vector));
            if (!CheckNumbersAreAllAndDistinct(vector))
                failure = true;

            sut.FakeSeed = 3;
            vector = sut.CompilaVettore(5);
            StringSet.Add(StringFromVector(vector));
            if (!CheckNumbersAreAllAndDistinct(vector))
                failure = true;

            sut.FakeSeed = 4;
            vector = sut.CompilaVettore(5);
            StringSet.Add(StringFromVector(vector));
            if (!CheckNumbersAreAllAndDistinct(vector))
                failure = true;

            sut.FakeSeed = 5;
            vector = sut.CompilaVettore(5);
            StringSet.Add(StringFromVector(vector));
            if (!CheckNumbersAreAllAndDistinct(vector))
                failure = true;

            if (StringSet.Count < 5)
                failure = true;

            Assert.False(failure);

        }

        private bool CheckNumbersAreAllAndDistinct(int[] vector)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int number in vector)
            {
                set.Add(number);   
            }
            if (set.Count < vector.Length)
                return false;

            return true;
        }

        private string StringFromVector(int[] vector)
        {
            StringBuilder builder = new StringBuilder();
            foreach (int number in vector)
            {
                builder.Append(number.ToString());    
            }
            return builder.ToString();
        }
    }
}
