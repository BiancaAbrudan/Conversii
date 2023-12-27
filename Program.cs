namespace Conversii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul in baza b1:");
            string numarInput = Console.ReadLine();
            Console.WriteLine("Introduceti baza initiala (b1):");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti baza de conversie (b2):");
            int b2 = int.Parse(Console.ReadLine());
            string rezultat = ConversieBaza(numarInput, b1, b2);
            Console.WriteLine($"Rezultatul conversiei este: {rezultat}");
        }
        static string ConversieBaza(string numarInput, int b1, int b2)
        {
            int numarDecimal = ConvertToDecimal(numarInput, b1);
            string rezultat = ConvertFromDecimal(numarDecimal, b2);
            return rezultat;
        }

        private static string ConvertFromDecimal(int numarDecimal, int b2)
        {
            string rezultat = " ";
            while (numarDecimal > 0)
            {
                int rest = numarDecimal % b2;
                char cifraChar;
                if (rest < 10)
                {
                    cifraChar = (char)('0' + rest);
                }
                else
                {
                    cifraChar = (char)('A' + rest - 10);
                }
                rezultat = cifraChar + rezultat;
                numarDecimal /= b2;
            }
            return rezultat;
        }

        static int ConvertToDecimal(string numarInput, int b1)
        {
            int rezultat = 0;
            int putere = 0;
            for(int i = numarInput.Length - 1; i>= 0; i--)
            {
                char cifraChar = numarInput[i];
                int cifra;
                if(char.IsDigit(cifraChar))
                {
                    cifra = cifraChar - '0';
                }
                else
                {
                    cifra = char.ToUpper(cifraChar) - 'A' + 10;
                }
                rezultat += cifra * (int)Math.Pow(b1, putere);
                putere++;
            }
            return rezultat;
          

        }
    }
}