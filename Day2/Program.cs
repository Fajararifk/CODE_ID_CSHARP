using static System.Console;
using Day2;

/*
 * //ArrayClass.IntroArray();

// CALL METHOD FUNCTION DARI RETURN
//int[] n = { 10, 20, 40, 50 };
//var myArray = ArrayClass.InitArrayInt(n});
*//*var myArray = ArrayClass.InitArrayInt(new int[] {10,20,40,50});

ArrayClass.DisplayArray(myArray);*//*

var myRandom = ArrayClass.InitArrayRandom(20);

ArrayClass.DisplayArray(myRandom);
WriteLine();
WriteLine($"Total Sum Random dari adalah {ArrayClass.FindSumElement(myRandom)}");
WriteLine();
WriteLine($"Nilai Terbesar dari array ini adalah {ArrayClass.FindLargestElement(myRandom)}");
WriteLine($"Nilai Terkecil dari array ini adalah {ArrayClass.FindSmallestElement(myRandom)}");
WriteLine($"Nilai Terbesar Kedua dari array ini adalah {ArrayClass.GreatestSecond(myRandom)}");
// COPY ARRAY
Console.WriteLine("=================COPY==================");
int[] newArray = new int[myRandom.Length];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = myRandom[i];
}
WriteLine();
ArrayClass.DisplayArray(newArray);
WriteLine();
var randomArray = new int[myRandom.Length];
Array.Copy(newArray, 0, randomArray, 0, newArray.Length);
// SORT ARRAY;
Console.WriteLine("\n=================REVERSED==================\n");
Array.Reverse(newArray);
ArrayClass.DisplayArray(newArray);

Console.WriteLine("\n=================SORT==================\n");
Array.Sort(newArray);
ArrayClass.DisplayArray(newArray);
*/
/*Day2.Matrix.InitMatrix();
var myMatrix = Day2.Matrix.FillRandomMatrix(5, 5);
Day2.Matrix.DisplayMatrix(myMatrix);*/
WriteLine();
//diagonal
var diagonal = Matrix.MatrixDiagonal2(5, 5);
//Matrix.DisplayMatrix(diagonal);
Matrix.DisplayMatrix(diagonal);


ReadLine();