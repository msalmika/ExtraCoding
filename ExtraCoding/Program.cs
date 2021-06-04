using System;

namespace ExtraCoding
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ex1();
            //Ex2();
            //Console.WriteLine(Ex3());
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            //C# strings
            //Ex8();
            //Ex9();
            //Ex10();
            //Ex11();
            //OOP
            //Ex12();
            //TestCalc();
            TestComp();
            
        }

        static void Ex1()
        {
            Console.WriteLine("        . ");
            Console.WriteLine("       \":\"  ");
            Console.WriteLine("    ____:___     |\"\\/\"|  ");
            Console.WriteLine("  ,'        `.    \\  /   ");
            Console.WriteLine("  |  0        \\___/  |   ");
            for (var i = 1; i < 28; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("^");
                }else
                {
                    Console.Write("~");
                }
            }

        }

        static void Ex2()
        {
            var eka = "MS";
            var toka = 5537116;
            var kolmas = 77130000000;
            var neljas = "keskiviikko";
            byte viides = 2;
            var PI = Math.PI;

            Console.WriteLine($"{eka} {toka} {kolmas} {neljas} {viides} {PI}");
        }

        static string Ex3()
        {
            Console.WriteLine("How many seconds do you have available?");
            int input = Convert.ToInt32(Console.ReadLine());
            var sekunnit = input;
            var minuutit = 0;
            var tunnit = 0;
            var paivat = 0;
            var vuodet = 0;

            while (sekunnit > 60)
            {
                sekunnit -= 60;
                minuutit += 1;
                if (minuutit == 60)
                {
                    tunnit += 1;
                    minuutit -= 60;
                }
                if (tunnit == 24)
                {
                    paivat += 1;
                    tunnit -= 24;
                }
                if (paivat == 365)
                {
                    vuodet += 1;
                    paivat -= 365;
                }
            }

            return $"{vuodet} years and {paivat} days and {tunnit} hours and {minuutit} minutes and {sekunnit} seconds";
        }

        static void Ex4()
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Capital Yes or No: ");
            var capital = Console.ReadLine();
            var isCapital = false;
            if (capital.ToLower() == "yes") { isCapital = true; }

            Console.WriteLine("Number of inhabitants: ");
            var numberOfInhabitants = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tax revenue per inhabitant: ");
            var taxRevenuePerInhabitant = Convert.ToDouble(Console.ReadLine());

            var isMetropolis = false;
            if ((isCapital == true && numberOfInhabitants > 100000)|(numberOfInhabitants > 200000 && (taxRevenuePerInhabitant*numberOfInhabitants) >= 1000000000))
            {
                isMetropolis = true;
            }
            
            if (isMetropolis == true)
            {
                Console.WriteLine("The city is a metropolis");
            } else
            {
                Console.WriteLine("The city is not a metropolis");
            }
        }

        static void Ex5()
        {
            var array = new int[9] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                
            }
        }

        static void Ex6()
        {
            int[] input = new int[] { 1, 4, 5, 7, 20000, -511, 100, -200, 400 };
            var summa = 0;
            foreach (var nro in input)
            {
                summa += nro;
            }
            Console.WriteLine(summa);
        }

        static void Ex7()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var kertotaulut = new int[numbers.Length][];

            for (var i = 0; i < numbers.Length; i++)
            {
                var rivi = new int[numbers.Length];
                for (var j = 0; j < numbers.Length; j++)
                {
                    rivi[j] = numbers[j] * numbers[i];
                }
                kertotaulut[i] = rivi;
            }

            for (var i = 0; i < kertotaulut.Length; i++)
            {
                for (var j = 0; j < kertotaulut.Length; j++)
                {
                    Console.Write(String.Format("{0,4}",kertotaulut[i][j]));
                }
                Console.WriteLine();
            }
        }

        static void Ex8()
        {
            var sentence = "Everyone _said_ that it would not work. Then someone came, #UNAWARE# of what everyone said, and just did it.";
            var asArray = sentence.Split(" ");
            var newSentence = "";
            foreach (var word in asArray)
            {
                var mid = "";
                if (word.Contains("_"))
                {
                    mid += word.ToUpper().Replace("_", "");
                }
                else if (word.Contains("#"))
                {
                    mid += word.ToLower().Replace("#", "");

                }
                else
                {
                    mid = word;
                }
                newSentence += $"{mid} ";
                Console.WriteLine(word);

            }

            Console.WriteLine(newSentence);
            
        }

        static void Ex9()
        {
            var sentence = "Everyone said that it would not work. Then someone came, unaware of what everyone said, and just did it.";
            var asArray = sentence.Split(" ");
            Console.WriteLine(asArray.Length);
        }

        static void Ex10()
        {
            var sentence = "Everyone said that it would not work. Then someone came, unaware of what everyone said, and just did it.";
            Console.WriteLine($"{sentence[0]} and {sentence[sentence.IndexOf(".") + 2]}");
            Console.WriteLine(sentence.CompareTo("not"));
            Console.WriteLine(sentence + " Marko");
            Console.WriteLine($"{sentence.Contains("did")} and {sentence.Contains("CSharp")}");
            Console.WriteLine(sentence.Equals(sentence));
            Console.WriteLine(sentence.IndexOf("d"));
            Console.WriteLine(String.IsNullOrEmpty(""));
            Console.WriteLine(String.IsNullOrEmpty(null));
            Console.WriteLine(sentence.Length);
            Console.WriteLine(sentence.Substring(9,4));
        }

        static void Ex11()
        {
            var str1 = "Equ";
            var str2 = "Equ";

            var str3 = new string("Equ");
            var str4 = new string("Equ");

            Console.WriteLine(str1 == str2);
            Console.WriteLine(str3 == str4);

            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str3.Equals(str4));

            Console.WriteLine(ReferenceEquals(str1, str2));
            Console.WriteLine(ReferenceEquals(str3, str4));


        }

        static void Ex12()
        {

        }

        static void TestCalc()
        {
            Calculator calculator = new Calculator(); 
            calculator.Add(8); Console.WriteLine(calculator.Result); 
            calculator.Multiply(2); 
            Console.WriteLine(calculator.Result); 
            calculator.Divide(4); 
            Console.WriteLine(calculator.Result); 
            // should print out: 4
        }

        static void TestComp()
        {
            var comp1 = new Computer("HP", 24, "No", purchaseprice: 200, saleprice: 500);
            var comp2 = new Computer("Acer", 24, "Yes", purchaseprice: 300, saleprice: 250);
            var comp3 = new Computer("HP", 18, "Yes", purchaseprice: 200, saleprice: 300);
            var comp4 = new Computer("Lenovo", 22, "No", 1200, 8, 500, 6, "laptop", 500, 600);

            var computers = new Computer[4] { comp1, comp2, comp3, comp4 };
            var totalProfit = 0;
            foreach (var computer in computers)
            {
                totalProfit += (computer.SalePrice - computer.PurchasePrice);
            }

            Console.WriteLine($"Total profit: {totalProfit}");

        }
    }
}
