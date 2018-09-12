using System;

namespace Crypteur
{
    class Program
    {
        static void Main(string[] args)
        {
            string dekrip = "";
            Random gen = new Random();
            int nrb = gen.Next(1, 14);

            Console.WriteLine("Quelle phrase voulez vous crypter?");
            string phrase = Console.ReadLine();

            for (int i = 0; i < phrase.Length; i++)
            {


                dekrip += Convert.ToChar((int)phrase[i] + nrb);

            }
            Console.WriteLine("Votre phrase devient " + dekrip + ". Votre clée est " + nrb);

            Console.ReadKey();


        }
    }
}
