namespace day01
{
    class StoreVariable
    {
        public static void StoreCharText()
        {
            // store charater
            char letter = 'A';
            char digit = '1';
            char symbol = '$';
            Console.WriteLine($"{letter} {digit} {symbol}");
        }
        public static void StoreString()
        {
            string firstName = "Fajar";
            string lastName = "Arif Kurniawan";
            Console.WriteLine(firstName + " "+ lastName);
        }
        public static void StoreVerbatin()
        {
            // literal string
            string fullName = "Fajar\tArif\tKurniawan";
            string filePath = "D:\\Belajar C#\\01-Fundamental\\bin\\Debug\\net6.0\\01-Fundamental";
            // @ Verbatin string : @ disable all escape characters so blackslash
            string filePath2 = @"D:\Belajar C#\01-Fundamental\bin\Debug\net6.0\01-Fundamental";

            Console.WriteLine($"{fullName} {filePath} {filePath2}");
        }
        public static void StoreNumber()
        {
            //unsigned integer : positive whole number or 0
            uint naturalNumber = 23;
            //integer : negative or positive whole number or 0
            int integerNumber = -23;
            //float means single precision floating point
            //f suffix makes it a float literal
            float realNumber = 2.3F;
            //double : double precision floating point
            double doubleNumber = 2.3;
        }
        // gunakan double or float for real numbers that will not be compare
        public static void ShowDouble()
        {
            Console.WriteLine("Using double : ");
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + b equals {0.3}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equal {0.3}");
            }
        }
        public static void ShowDecimal()
        {
            decimal a= 0.1M; // M suffix means to decimal value
            decimal b= 0.2M;
            if (a + b == 0.3M)
            {
                Console.WriteLine($"{a} + b equals {0.3}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equal {0.3}");
            }
        }
        public static void StoreBoolean()
        {
            bool isStatus = true;
            bool isMarried = false;
        }

        public static void StoreObject()
        {
            object obj = null;
            object firstName = "CodeID";
            object height = 165;

            int lengthName = ((string)firstName).Length;
            Console.WriteLine($"{firstName} is {height} metress tall , lengthName: {lengthName}" );
        }
        //boxing unboxing, stack vs heap memory
        public static void BoxingUnboxing()
        {
            int a = 42;
            object obj = a;

            obj = 45;
            int b = (int)obj;
        }
        public static void ShowDataTypeRange()
        {
            Console.WriteLine($"sbyte {sbyte.MinValue} {sbyte.MaxValue}");
            Console.WriteLine($"int {int.MinValue} {int.MaxValue}");
            Console.WriteLine($"double {double.MinValue} {double.MaxValue}");
            Console.WriteLine($"decimal {decimal.MinValue} {decimal.MaxValue}");

        }
        public static void ShowCasting()
        {
            //cast int to double
            int a = 10;
            double d = a;
            Console.WriteLine($"{d}");

            //cast double to int
            //because value different max and min 
            double c = 9.8;
            int b = (int)c;
        }
        public static void StoreDynamic()
        {
            // dynamic has no method or attribute
            dynamic myName = "Fajar Arif Kurniawan";
            Console.WriteLine($"{myName}");
        }
        public static void StoreLocal()
        {
            int salary = 10_000_000;
            double weight = 5.55;
            decimal price = 15.500M;// IN IDR
            string myName = "code.id";
            char letter = 'Z';
            bool merried = false;

            var salaryy = 10_000_000;
            var weighty = 5.55;
            var pricee = 15.500M;// IN IDR
            var myNamee = "code.id";
            var letterr = 'Z';
            var merriedd = false;
        }
        public static void PassingParams(string message)
        {
            Console.WriteLine($"Hello {message}");
        }
        public static void ShowNullableType()
        {
            Nullable<int> a;
            Nullable<int> b = null;
            Nullable<int> c = 42;

            // lebih singkat
            int? d;
            int? e = null;
            int? f = 42;

            if (c.HasValue)
                Console.WriteLine(c.Value);
        }
        public static void ShowDiffDate()
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(50);
            DateTime.Compare(startDate, endDate);

            Console.ReadLine();
        }
        public static void ShowArray()
        {
            int[] arr = new int[] {1, 2, 3};
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public static void ShowList()
        {
            var numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(15);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        public static void ShowConsole()
        {
            int numberOfIphone = 12;
            decimal pricePerIphone = 1.35M;
            Console.WriteLine(
                format : "{0} iphone cost  {1:C}",
                arg0: numberOfIphone,
                arg1: pricePerIphone * numberOfIphone);
            //interpolate string
            Console.WriteLine($"{numberOfIphone} iphone cost {pricePerIphone * numberOfIphone}");
        }
        public static void ReadConsole()
        {
            Console.WriteLine("FirstName : ");
            string? firstName = Console.ReadLine();

            Console.WriteLine("age : ");
            string? age = Console.ReadLine();

            Console.WriteLine($"Hello {firstName}, you look young for age {age}");
        }
        public static void ReadConsoleKey()
        {
            Console.Write("Press C for continue or Esc for Exit");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            if (key.Key == ConsoleKey.C)
            {
                Console.WriteLine("Continue process");
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Quit Process");
            }
        }
    }
}