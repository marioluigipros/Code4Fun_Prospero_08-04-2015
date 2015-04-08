using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi
{
    public class Esercizi
    {
        int[] MultiplesAtStepN;
        int[] MultiplesOfnNumberFinished;
        public int FakeSeed = 0;
        public decimal MakeSumOfMultiples(int[] numbers, int limit)
        {
            int vectorLength = numbers.Length;
            MultiplesAtStepN = new int[vectorLength];
            int noMoreMultiples = vectorLength;
            bool bException = false;
            
            int partialSum = 0;
            int globalSum = 0;

            MultiplesOfnNumberFinished = new int[vectorLength];
            for (int i = 0; i < vectorLength; i++)
            {
                MultiplesOfnNumberFinished[i] = 0;    
            }
            

            for (int i = 0; i < vectorLength; i++)
            {
                MultiplesAtStepN[i] = numbers[i];   
            }

            try
            {
                while (!CheckMultiplesAreFinished())
                {
                    for (int i = 0; i < vectorLength; i++)
                    {
                        if (MultiplesAtStepN[i] < limit)
                            partialSum += MultiplesAtStepN[i];
                        else
                            MultiplesOfnNumberFinished[i] = 1;
                    }


                    globalSum += partialSum;
                    partialSum = 0;

                    for (int i = 0; i < vectorLength; i++)
                    {
                        MultiplesAtStepN[i] += numbers[i];
                    }


                }

                
            }
            catch (Exception exc)
            {
                bException = true;
                Console.WriteLine("Il programma ha generato l'eccezione: "+exc.Message);
            }


            if (bException)
                return -1;

            return globalSum;
            
        }

       

        private bool CheckMultiplesAreFinished()
        {
            int sum=0;

            for (int i = 0; i < MultiplesOfnNumberFinished.Length; i++)
            {
                sum += MultiplesOfnNumberFinished[i];      
            }

            if (sum == MultiplesOfnNumberFinished.Length)
                return true;
            return false;
        }

        public int[] CompilaVettore(int vectorLength)
        {
            int[] vector = new int[vectorLength];            
            int[] returnVector = new int[vectorLength];

            Random rand = new Random();        

            
            int seed = FakeSeed > 0 ? FakeSeed: rand.Next(1,vectorLength);

           
            for (int i = 1; i <= vectorLength; i++)
            {               

                if ((seed + (i-1)) < vectorLength)
                    returnVector[seed + i - 1] = i;
                else if((((seed + i) % vectorLength) == 0) && seed>1)
                    returnVector[vectorLength - 1] = i;
                else
                    returnVector[((seed + i) % vectorLength) - 1] = i;
    
            }
            return returnVector;
        }
    }
}
