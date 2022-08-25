namespace day01
{
    class Iterator
    {
        public static void ShowOddEventNumber()
        {
            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} adalah bilangan genap");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{i} adalah bilangan ganjil");
                }
            }
        }
        public static void ShowColumn()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
        }
        public static void ShowRow()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i} ");
            }
        }
        public static void ShowBox()
        {
            // cetak baris bawah
            for (int i = 0; i < 5; i++)
            {
                //cetak kolom kanan
                for (int j = 0; j  <5; j ++) 
                {
                    Console.Write($"{i+j}");
                }
                Console.WriteLine();
            }
        }
        public static void ShowLeftTriangle()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + j);
                }
                Console.WriteLine();
            }
        }
        public static void ShowRightTriangle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5-1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1;j<= i +1; j++)
                {
                    Console.Write(i + j);
                }
                Console.WriteLine();
            }
        }
        public static void ShowContinueStmt()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        public static void ShowWhileDo()
        {
            int i = 0;
            while ( i <= 20)
            {
                Console.WriteLine("Iteration : " + i);
                i++;
                if (i == 10)
                    break;
            }
        }
        public static void ShowDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"{i}");
                i++;
            } while (i <= 10);
        }
    }
}