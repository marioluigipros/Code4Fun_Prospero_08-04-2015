using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi
{
    public class Esercizi
    {
        int[] multiplesAtStepN;
        int[] multiplesOfnNumberFinished;
        public decimal SommaMultipliNnumeriMinoriDi(int[] numbers, int limit)
        {
            int vectorLength = numbers.Length;
            multiplesAtStepN = new int[vectorLength];
            int noMoreMultiples = vectorLength;
            
            int partialSum = 0;
            int globalSum = 0;

            multiplesOfnNumberFinished = new int[vectorLength];
            for (int i = 0; i < vectorLength; i++)
            {
                multiplesOfnNumberFinished[i] = 0;    
            }
            

            for (int i = 0; i < vectorLength; i++)
            {
                multiplesAtStepN[i] = numbers[i];   
            }

            while (!CheckMultiplesAreFinished())
            {
                for (int i = 0; i < vectorLength; i++)
                {
                    if (multiplesAtStepN[i] < limit)
                        partialSum += multiplesAtStepN[i];
                    else
                        multiplesOfnNumberFinished[i]=1;    
                }
                

                globalSum += partialSum;
                partialSum = 0;               

                for (int i = 0; i < vectorLength; i++)
                {
                    multiplesAtStepN[i] += numbers[i];                    
                }

                    
            }

           
            return globalSum;
        }

        private bool CheckMultiplesAreFinished()
        {
            int sum=0;

            for (int i = 0; i < multiplesOfnNumberFinished.Length; i++)
            {
                sum += multiplesOfnNumberFinished[i];      
            }

            if (sum == multiplesOfnNumberFinished.Length)
                return true;
            return false;
        }

        public int[] CompilaVettore(int[] vettore)
        {
            return null;
        }
    }
}
