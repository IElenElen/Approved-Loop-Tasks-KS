namespace Approved_Loop_Tasks_KS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Approved Loop Tasks");

            Console.WriteLine("Task no 1");
            //Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 - 100.

            bool IsPrime(int noNumber)
            {
                if (noNumber <= 1)
                {
                    return false;
                }
                for (int i = 2; i * i <= noNumber; i++)
                {
                    if (noNumber % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine("Liczby pierwsze od 0 do 100");
            for (int p = 0; p <= 100; p++)
            {
                if (IsPrime(p))
                {
                    Console.WriteLine(p);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Task no 2");
            //Napisz program, który za pomocą pętli do while znajdzie wszystkie liczby parzyste z zakresu 0 - 1000.

            int n = 0;
            Console.WriteLine("Liczby parzyste od 0 do 1000");

            do
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"{n}");
                }
                n++;
            }
            while (n <= 1000);
            Console.WriteLine();

            Console.WriteLine("Task no 3");
            // Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

            int nstr = 10; //długość ciągu
            int a = 0; int b = 1;
            for (int i = 0; i < nstr; i++)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();

            Console.WriteLine("Task no 4");
            //Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do 10, w formie jak poniżej:
            //1
            //2 3
            //4 5 6
            //7 8 9 10

            Console.WriteLine("Podaj liczbę całkowitą:");
            int lc;
            if (int.TryParse(Console.ReadLine(), out lc))
            {
                int currentLc = 1;

                for (int i = 1; i <= lc; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(currentLc + " ");
                        currentLc++;
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Błąd. Podaj liczbę całkowitą: ");
            }
            Console.WriteLine();

            Console.WriteLine("Task no 5");
            //Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            for (int i = 1; i <= 20; i++)
            {
                int cubed = i * i * i;
                Console.WriteLine($"Potęga trzecia liczby {i} to {cubed}");
            }
            Console.WriteLine();

            Console.WriteLine("Task no 6");
            //Napisz program, który dla liczb od 0 do 20 obliczy sumę wg. wzoru:
            //1+1/2+1/3+1/4 itd.
            
            double sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine($"Suma dla szeregu harmonicznego wynosi: {sum}");
            Console.WriteLine();

            Console.WriteLine("Task no 7");
            //Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej
            //o długości wprowadzonej przez użytkownika i wzoru:
            //  *
            //* * *
            //5 gwiazdek
            //7 gwiazdek
            //9 
            //7
            //5
            //3
            //1

            int lengthDiamond = 9;
            int shorterDiagonal = lengthDiamond / 2 + 1;
            int spacesNo = shorterDiagonal - 1;
            int starsNo = 1;

            for (int i = 0; i < shorterDiagonal; i++) //Górna część
            {
                for (int j = 0; j < spacesNo; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < starsNo; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < spacesNo; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                spacesNo--;
                starsNo += 2;
            }
            spacesNo = 1;
            starsNo = lengthDiamond - 2;
            for (int i = 0; i < shorterDiagonal - 1; i++) //Dolna część
            {
                for (int j = 0; j < spacesNo; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < starsNo; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                spacesNo++;
                starsNo -= 2;
            }
            Console.WriteLine();

            Console.WriteLine("Task no 8");
            //Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. np. 
            //Abcdefg  na
            //Gfedcba
            
            string str = "abcdefg";
            char[] singleChar = str.ToCharArray();
            int length = singleChar.Length;

            for (int i = 0, j = length - 1; i < j; i++, j--)
            {
                char temp = singleChar[i];
                singleChar[i] = singleChar[j];
                singleChar[j] = temp;
            }
            string revStr = new string(singleChar);
            Console.WriteLine(revStr);
            Console.WriteLine();

            Console.WriteLine("Task no 9");
            //Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            //decimal number
            //binary number

            Console.WriteLine("Podaj liczbę dziesiętną");
            string? decNo = Console.ReadLine();
            int bin;

            if (int.TryParse(decNo, out bin))
            {
                Console.WriteLine("Konwersja powiodła się");
                string binNo = "";

                while (bin > 0)
                {
                    int rest = bin % 2;
                    binNo = rest.ToString() + binNo;
                    bin = bin / 2;
                }
                Console.WriteLine($"Liczba dziesiętna {decNo} to liczba binarna {binNo}");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadź liczbę dziesiętną");
            }
            Console.WriteLine();

            Console.WriteLine("Task no 10");
            //Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

            Console.WriteLine("Podaj pierwszą liczbę");
            string? inputNo1 = Console.ReadLine();
            int no1str;

            Console.WriteLine("Podaj drugą liczbę");
            string? inputNo2 = Console.ReadLine();
            int no2str;

            if (int.TryParse(inputNo1, out no1str) && int.TryParse(inputNo2, out no2str))
            {
                int scm = CalculateLcmSCM(no1str, no2str);
                Console.WriteLine($"Najmniejsza wspólna wielokrotność dla {no1str} i dla {no2str} to: {scm}");
            }
            else
            {
                Console.WriteLine("Nieprawidłowe dane");
            }
            int CalculateLcmSCM(int a, int b)
            {
                int gcd = CalculateGCD(a, b);
                return (a * b) / gcd;
            }
            int CalculateGCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
        }
    }
}
