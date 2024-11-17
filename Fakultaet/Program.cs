using System.Numerics; //brauch man durch BigInt

namespace Fakultaet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number = 21;
            
            try
            {
                ulong ergebniss = CalculateFactorial(number); //max ist ulong
                Console.WriteLine($"Die Fakultät von {number} ist {ergebniss}");
            }
            catch (OverflowException) //wenn ein Overflow auftritt wird dieser Bereich ausgeführt.
            {
                Console.WriteLine("Ein Overflow ist aufgetreten.");
            }

            // Testen der CalculateBigFactorial Methode
            uint bigNumber = 50;
            try
            {
                BigInteger bigErgebniss = CalculateBigFactorial(bigNumber);
                Console.WriteLine($"Die Fakultät von {bigNumber} ist {bigErgebniss}");
            }
            catch (OverflowException) //wenn ein Overflow auftritt wird dieser Bereich ausgeführt.
            {
                Console.WriteLine("Ein Overflow ist aufgetreten.");
            }
        }

        //Berechnet die Fakultät bis 20
        public static ulong CalculateFactorial(uint number)
        {
            ulong result = 1;

            checked //Prüft nach Overflow
            {
                for (ulong i = 1; i <= number; i++) //rechnet immer das ergebnis * i++
                {
                    result *= i;
                }
            }
            return (result);
        }

        //Berechnet die Fakultät
        public static BigInteger CalculateBigFactorial(uint number)
        {
            BigInteger result = 1;

            checked //Prüft nach Overflow
            {
                for (uint i = 1; i <= number; i++) //rechnet immer das ergebnis * i++
                {
                    result *= i;
                }
            }
            return result;
        }
    }
}
