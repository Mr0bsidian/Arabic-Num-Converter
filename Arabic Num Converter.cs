using System;
using System.Collections.Generic;

class ArabicToRomanConverter
{

    static void Main()
    {
        //Do while loop to restart program after the first rerun
        char weiter = 'W';
        do
        {
            int arabicNum;
            string romanNum = "";

            //Refrencing Roman Numbers to arabic numbers 
            Dictionary<int, string> romanDict = new Dictionary<int, string>() {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

            Console.Write("Geben Sie eine arabische Zahl ein: ");
            arabicNum = int.Parse(Console.ReadLine());

            //Outputting error message if the number is under 1 or over 4000
            if (arabicNum < 1 || arabicNum > 4000)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 4000 ein.");
                return;
            }

            //pairing roman numbers together and subtracting arabic numbers
            foreach (KeyValuePair<int, string> pair in romanDict)
            {
                while (arabicNum >= pair.Key)
                {
                    romanNum += pair.Value;
                    arabicNum -= pair.Key;
                }
            }
            Console.WriteLine("Die römische Zahl ist: " + romanNum);

            Console.WriteLine("[W]eiter oder [B]eenden");
            weiter = Console.ReadKey().KeyChar;
            Console.WriteLine();

        }
        while (weiter == 'w' || weiter == 'W');
    }
}

