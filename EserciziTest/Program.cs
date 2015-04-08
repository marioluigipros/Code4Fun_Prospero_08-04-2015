using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Esercizi esercizi = new Esercizi();
            int[] vect=new int[2]{3,5};
            int[] vect1 = new int[5];
            int vectorLength;
            if(args.Length==1)
            {
                int.TryParse(args[0],out vectorLength);
                if(vectorLength!=null)
                {
                    int[] vect2 = esercizi.CompilaVettore(vectorLength);

                    string output = string.Empty;

                    for (int i = 0; i < vect2.Length; i++)
                    {
                        output += vect2[i].ToString() + " ";
                    }

                    Console.Write(output);
                }
                return;
            }           
            
            decimal d=esercizi.MakeSumOfMultiples(vect, 1000);
            Console.Write("La somma dei multipli di 3 e 5 inferiori a mille è: " + d);
        }
    }
}
