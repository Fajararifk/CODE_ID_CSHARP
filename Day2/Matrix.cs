namespace Day2
{
    internal class Matrix
    {
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];
            matrix[2, 2] = 125;
        }
        public static int[,] FillRandomMatrix(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(0, 20);
                }
            }
            return matrix;
        }
        public static int[,] MatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 1;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal itu baris dan kolom sama
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                    } else if ( j > i)
                    {
                        matrix[i, j] = 10;
                    } else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }

        public static int[,] MatrixDiagonal2(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 5;
            for (int i = 0; i < matrix.GetLength(0);i ++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal itu baris dan kolom sama
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
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
}