using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaltest
{
    internal class finalTest
    {

        public static float katak()
        {
            int x = 10;
            int y = 85;
            int k = 30;
            float hitung = 0F;
            var xk = x+k;
            for (int i = 0; i < y; i++)
            {
                if(xk <= y)
                {
                    hitung++;
                    xk += x+k;
                }
            }
            return hitung;
        }
        public static int factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int sum(int n)
        {
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result+=i;
            }
            return result;
        }

        public static int fibonacci(int n)
        {
            int f1, f2 = 1, f3 = 0;
            f1 = f2 + f3;
            for (int i = 1; i < n; i++)
            {
                f1 = f2 + f3;
                f3 = f2;
                f2 = f1;
            }
            return f1;
        }

        public static void ShowFibo(int n)
        {
            int f1, f2 = 1, f3 = 0;
            f1 = f2 + f3; // awalawannya f1 1
            for (int i = 1; i < n; i++) // i = 1,2,3         || n == 5
            {
                f1 = f2 + f3;
                f3 = f2; 
                f2 = f1;
                Console.Write(f1 + " ");
            }
        }

        public static bool CheckKurawal(string kurawal)
        {
            bool result = false;
            for (int i = 0; i < kurawal.Length; i++)
            {
                if(kurawal == "{}" || kurawal == "{{}}")
                {
                    result = true;
                }
                else if (kurawal == "{" || kurawal == "{{}" || kurawal == "{}}")
                {
                    result = false;
                }
                
            }
            return result;
        }

        public static bool IsAnagram(string s1, string s2)
        {
            var result = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if(s1.Length == s2.Length)
                {
                    result = true;
                }
                else if (s1.Length != s2.Length)
                {
                    result = false;
                }
            }
            return result;
        }

        public static int[,] MatrixColumn1(int row, int col)
        {
            var matrix = new int[row, col];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        matrix[i,j] = 10;
                    }
                    else if (j == 1 && i < row-1)
                    {
                        matrix[i, j] = 9;
                    }
                    else if (j == 2 && i < row - 2)
                    {
                        matrix[i, j] = 8;
                    }
                    else if (j == 3 && i < row - 3)
                    {
                        matrix[i, j] = 7;
                    }
                    else if (j == 4 && i < row - 4)
                    {
                        matrix[i, j] = 6;
                    }

                }
            }
            return matrix;
        }

        public static int[,] MatrixColumn2(int row, int col)
        {
            var matrix = new int[row, col];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] += i+1;
                    }
                    else if ( j == 1  && i >= 1)
                    {
                        matrix[i, j] += i +2;
                    }
                    else if (j==2 && i >= 2)
                    {
                        matrix[i, j] += i+3;
                    }
                    else if (j == 3 && i >= 3)
                    {
                        matrix[i, j] += i + 4;
                    }
                    else if (j == 4 && i >= 4)
                    {
                        matrix[i, j] += i + 5;
                    }
                }
            }
            return matrix;
        }

        public static int[,] MatrixColumn3(int row, int col)
        {
            var matrix = new int[row, col];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j ==1 && i >=1 && i < row - 1)
                    {
                        matrix[i, j] = 2;
                    }
                    else if (j == 2 && i >= 2 && i < row - 2)
                    {
                        matrix[i, j] = 3;
                    }
                    else if (j == 3 && i >= 3 && i < row - 3)
                    {
                        matrix[i, j] = 4;
                    }
                }
            }
            return matrix;
        }

        public static int[,] MatrixColumn4(int row, int col)
        {
            var matrix = new int[row, col];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 4)
                    {
                        matrix[i, j] += i+1;
                        if(i == 1)
                        {
                            matrix[i, j] += i;
                        }
                        else if (i == 2)
                        {
                            matrix[i, j] += i;
                        }
                        else if (i == 3)
                        {
                            matrix[i, j] += i;
                        }
                        else if (i == 4)
                        {
                            matrix[i, j] += i;
                        }
                    }
                    else if ((j == 3 || j == 5) && i > 0)
                    {
                        matrix[i, j] += i + 1;
                        if(i == 2)
                        {
                            matrix[i, j] += i-1;
                        }
                        else if (i == 3)
                        {
                            matrix[i, j] += i - 1;
                        }
                        else if (i == 4)
                        {
                            matrix[i, j] += i - 1;
                        }
                    }
                    else if ((j == 2 || j == 6) && i > 1)
                    {
                        matrix[i, j] += i + 1;
                        if( i == 3)
                        {
                            matrix[i, j] += i - 2;
                        }
                        if (i == 4)
                        {
                            matrix[i, j] += i - 2;
                        }
                    }
                    else if ((j == 1 || j == 7) && i > 2)
                    {
                        matrix[i, j] = i + 1;
                        if( i == 4)
                        {
                            matrix[i, j] += i - 3;
                        }
                    }
                    else if ((j == 0 || j == 8) && i > 3)
                    {
                        matrix[i, j] = i + 1;
                    }
                }
            }
            return matrix;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) //baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //colom
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    /*internal class A
    {
        private string a;
        public doA(string a)
        {
            this.a = a;
            Console.WriteLine("A says "+ a);
        }
    }
    internal class B : A
    {
        private string b;
        public doB(string a, string b) : base(a)
        {
            this.b = b;
            Console.WriteLine("B says " + b);
        }
    }
    class C : B
    {
        public static void doA()
        {
            string c = null;
            Console.WriteLine("Who cares what A says");
        }
        public static void doB()
        {
            Console.WriteLine("Who cares what B says");
        }
        public static void doC()
        {
            Console.WriteLine("C says " + a + " " + b + " " + c);
        }
    }*/
}
