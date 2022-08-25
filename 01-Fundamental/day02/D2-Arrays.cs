namespace day02
{
    class Arrays
    {
        // initial array
        public static void InitArrays()
        {
            int[] arr = new int[2];
            // fill element
            arr[0] = 1;
            arr[1] = 2;

            int[] arr2 = new int[] { 2, 3, 5, 7 };

            int[] arr3 = { 10, 20, 30, 40 };

            double[] arr4 = new double[2];
            arr4[0] = 34.5;

            string[] arr5 = { "Fajar", "Arif", "Kurniawan" };

            DisplayArraysInt(arr2);
            Console.WriteLine("\n");
            DisplayArraysString(arr5);
            Console.WriteLine("\n" );
            var sum = SumAllElement(arr3);
            Console.WriteLine($"Total Array : {sum}");
            Console.WriteLine("\n");

            // find largest
            var arr6 = new int[] { 1, 54, 78, 90, 3, 56, 76 };
            var max = FindingMaxElement(arr6);
            Console.WriteLine($"Total Max: {max}");
            // find smallest
            var min = FindingMinElement(arr6);
            Console.WriteLine($"Total Min: {min}");



        }
        public static void DisplayArraysInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            
        }
        public static void DisplayArraysString(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        public static void DisplayArraysChar(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        // SUM ALL ELEMENT ARRAY
        public static Double SumAllElement(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int FindingMaxElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                // cek mana paling max
                if(arr[i]> max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int FindingMinElement(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static void CopyingArray()
        {
            int[] sourceArray = { 2, 3, 5, 7, 11, 9 };
            int[] targetArray = new int[sourceArray.Length];
            // KALO INI TARGETNYA TIDAK AKAN BERUBAH

            // case : target array
            /*targetArray = sourceArray;*/
            // KALO SOURCEARRAY BERUBAH MAKA TARGETNYA BERUBAH
            // cara 1
          /*  for (int i = 0; i < sourceArray.Length; i++)
            {
                targetArray[i] = sourceArray[i];
            }*/

            // cara 2 
            Array.Copy(sourceArray, targetArray, sourceArray.Length);

            // sorting
            Array.Sort(targetArray);
            DisplayArraysInt(targetArray);
        }

        // fill element array with random int
        public static void FillRandomArray()
        {
            Random random = new Random();
            // fill integer
            var listInt = new int[100];
            for (int i = 0; i < listInt.Length; i++)
            {
                listInt[i] = random.Next(0, 100);
            }
            // fill char
            char[] charArray = new char[100];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = (char)random.Next('a', 'z');
            }
            DisplayArraysInt(listInt);
            Console.WriteLine("\n");
            DisplayArraysChar(charArray);
            
        }
        
    }
}