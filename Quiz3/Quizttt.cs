﻿using System.Collections;

namespace Quiz3
{
    internal class Quiz
    {
        public static void No1()
        {
            var inputA = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var inputB = new HashSet<int>() { 1, 2, 3, 4 };
            Console.WriteLine("Nomor 1\n");
            Console.WriteLine("Tampilkan element yang sama (A irisan B)\n");
            var r1 = new HashSet<int>(inputA);
            IEnumerable<int> no1A = r1.Intersect(inputB);
            foreach (var item in no1A)
            {
                Console.Write(item + " ");
            }
            //Console.WriteLine("========Irisan========\n");

            Console.WriteLine("\n\nMerge dan tampilkan element (A union B)\n");
            IEnumerable<int> no1B = r1.Union(inputB);
            //SortedSet<int> no1BB = new SortedSet<int>(r1);
            //r1.Union(inputB);
            foreach (var item in no1B)
            {
                Console.Write(item + " ");

            }

            Console.WriteLine("\n\nTampilkan element di A yang tidak sama dengan B\n");
            IEnumerable<int> no1C = r1.Except(inputB);
            foreach (var item in no1C)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nTampilkan element yang tidak sama dengan A&B\n");
            r1.SymmetricExceptWith(inputB);
            var no1D = r1.ToList();
            foreach (var item in no1D)
            {
                Console.Write(item + " ");
            }

        }

        public static List<T> DisplayList<T>(ref List<T> List)
        {
            var myList = new List<T>();
            foreach (var item in List)
            {
                myList.Add(item);
            }
            return myList;
        }
        public static List<T> No2<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }
            myList.Reverse();


            return myList;
            /*var inputA = new HashSet<int>() { 1, 2, 3, 4 };
            var inputB = new HashSet<string>() { "A", "BB", "CCC", "DDDD" };*/
            /*var r2 = new HashSet<int>(inputA);
            IEnumerable<int> no2A = r2.Reverse(inputA);*/
            /*Console.WriteLine("\n\nNomor 2\n");
            Console.WriteLine("\nInput dari Sebuah Integer, Reversenya : \n");
            List<int> inputInt = new List<int>();
            inputInt.Add(1);
            inputInt.Add(2);
            inputInt.Add(3);
            inputInt.Add(4);
            Console.WriteLine();
            inputInt.Reverse();
            foreach (var item in inputInt)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nInput dari Sebuah String, Reversenya : \n");
            List<string> inputStr = new List<string>();
            inputStr.Add("A");
            inputStr.Add("BB");
            inputStr.Add("CCC");
            inputStr.Add("DDDD");
            inputStr.Reverse();
            foreach (var item in inputStr)
            {
                Console.Write(item + " ");
            }*/
        }

        public static List<T> No3<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }
            var removed = myList.Distinct().ToList();


            return removed;
            /*Console.WriteLine("\n\n Nomor3 \n ");
            Console.WriteLine("\nNomor 3A \n");
            List<int> no3A = new List<int>();
            no3A.Add(1);
            no3A.Add(1);
            no3A.Add(2);
            no3A.Add(3);
            no3A.Add(4);
            no3A.Add(1);
            no3A.Add(2);
            no3A.Add(3);
            List<int> duplicatedA = no3A.Distinct().ToList();
            foreach (var item in duplicatedA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nNomor 3B \n");
            List<int> no3B = new List<int>();
            no3B.Add(7);
            no3B.Add(5);
            no3B.Add(3);
            no3B.Add(5);
            no3B.Add(1);
            List<int> duplicatedB = no3B.Distinct().ToList();
            foreach (var item in duplicatedB)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nNomor 3C \n");
            List<int> no3C = new List<int>();
            no3C.Add(1);
            no3C.Add(1);
            no3C.Add(1);
            no3C.Add(1);
            no3C.Add(1);
            no3C.Add(1);
            List<int> duplicatedC = no3C.Distinct().ToList();
            foreach (var item in duplicatedC)
            {
                Console.Write(item + " ");
            }*/
        }

        public static int GetRightPosition(List<int> output, int value)
        {
            int l = 0;
            int r = output.Count - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (output[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return l;
        }

        public static bool IsElementExist(List<int> output, int value)
        {
            int l = 0;
            int r = output.Count - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (output[mid] == value)
                {
                    return true;
                }

                if (output[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return false;
        }

        public static List<int> LongestIncreasingSubSequence(int[] input)
        {
            List<int> output = new List<int>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (output.Count == 0)
                {
                    output.Add(input[i]);
                    dictionary[input[i]] = Int32.MinValue;
                }
                else
                {
                    if (!IsElementExist(output, input[i]))
                    {
                        if (input[i] > output.Last())
                        {
                            output.Add(input[i]);
                            dictionary[input[i]] = output[output.Count - 2];
                        }
                        else
                        {
                            int position = GetRightPosition(output, input[i]);

                            output[position] = input[i];

                            if (position == 0)
                            {
                                dictionary[input[i]] = Int32.MinValue;
                            }
                            else
                            {
                                dictionary[input[i]] = output[position - 1];
                            }

                        }
                    }
                }
            }

            int lastElement = output.Last();
            List<int> finalResult = new List<int>();

            while (lastElement != Int32.MinValue)
            {
                finalResult.Add(lastElement);
                lastElement = dictionary[lastElement];
            }

            return finalResult;
        }


        /*no4A.Add(1);
        no4A.Add(1);
        no4A.Add(2);
        no4A.Add(3);
        no4A.Add(4);
        no4A.Add(1);
        no4A.Add(2);
        no4A.Add(3);

        var inputA = new HashSet<int>() { 1, 1, 2, 3, 4, 1, 2, 3 };

        var max = int.MinValue;
        foreach(var item in inputA)
        {
            if( item > max)
            {
                max = item;
            }
        }
        Console.WriteLine(inputA);*/

        public static List<T> No5<T>(ref List<T> list, ref List<T> list2)
        {
            var same = new List<T>();
            var different = new List<T>();
            var myList = new List<T>();
            var aku = new int[list.Count];
            var kamu = new int[list2.Count];
            /*string[] same = new string[myList.Count];
            string[] different = new string[myList.Count];*/
            /*for (int i = 0; i < aku.Count; i++)
            {
                int hitung = 1;
                for (int j = i; j < aku.Count; j++)
                {
                    if (aku[i] == aku[j])
                    {
                        hitung++;
                    }
                }
            }*/
            return myList;
        }

        /*public static List<int> No6(int[] list)
        {
            var myList = new List<int>();
            int hitung;
            var aku = new int[list.Length];
            foreach (var item in list)
            {
                hitung = 0;
                foreach (var item2 in list)
                {
                    if (item == item2)
                    {
                        hitung++;
                        if(hitung > 0)
                        {
                            if (!myList.Contains(item))
                            {
                                myList.Add(item2);
                            }
                        }
                        
                    }
                }
                Console.WriteLine($"{item} = {hitung}");
            }
            return myList;
        }*/
        public static Dictionary<int,long>ValueCount<T>(List<T> list)
        {
            var myList = new Dictionary<int,long>();
            int hitung = 0;
            foreach (var item in list)
            {
                foreach (var item2 in list)
                {
                    if (item.Equals(item2))
                    {
                        hitung++;
                   /*     if(hitung > 0)
                        {
                            if(myList)
                            {

                            }
                        }*/
                    }
                }
            }
            return myList;
        }
    }
}