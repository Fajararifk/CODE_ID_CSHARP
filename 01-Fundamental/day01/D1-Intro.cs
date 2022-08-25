namespace day01
{
    class Intro
    {
        public static void ShowConsole()
        {
            // 1. OUTPUT SHOW NORMAL TEXT
            Console.WriteLine("Fajar Arif Kurniawan");

            // 2. CONCAT

            Console.WriteLine("Code Academy " + "Bootcamp .NET");

            //3.
            Console.WriteLine("Code Academy \nCool .NET");

            //4.
            Console.WriteLine("I love Programming \"C#\"");

            //5.
            Console.WriteLine("Greek alphabet for B : \u03B2");

            //6.
            Console.WriteLine("D:\\Belajar C#\\01-Fundamental\\bin\\Debug\\net6.0\\01-Fundamental");


            //7.
            Console.WriteLine(@"Bootcamp .NET with CodeID Academy
Location Sentul City
Bogor
");

            //8.
            Console.WriteLine(
                @"Which best programming languange
=========================
");
            Console.WriteLine("a) Java");
            Console.WriteLine("b) C#");
            Console.WriteLine("c) Golang");

            //9. Formatted number
            Console.WriteLine("Temperatur on {0:D} is {1}C", DateTime.Today, 36.5);
        }
    }
}