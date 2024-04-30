using Petras.HashTable;
using Petras.StringManipulations;
using System.Collections;

Permutations c = new Permutations();

var result=c.CheckPermutation("ab", "eidboaooo");

var test = "";




//static void SetZeroes(int[][] matrix)
//{
//    HashSet<int> rows = new HashSet<int>();
//    HashSet<int> cols = new HashSet<int>();

//    // First pass: Identify rows and columns containing zeros
//    for (int i = 0; i < matrix.Length; i++)
//    {
//        for (int j = 0; j < matrix[0].Length; j++)
//        {
//            if (matrix[i][j] == 0)
//            {
//                rows.Add(i);
//                cols.Add(j);
//            }
//        }
//    }

//    // Second pass: Set entire row and column to zero if any element in it is zero
//    for (int i = 0; i < matrix.Length; i++)
//    {
//        for (int j = 0; j < matrix[0].Length; j++)
//        {
//            if (rows.Contains(i) || cols.Contains(j))
//            {
//                matrix[i][j] = 0;
//            }
//        }
//    }
//}
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Hello, World!");
//}


//int[][] matrix = new int[][]
//       {
//            new int[] {1, 2, 3},
//            new int[] {4, 0, 6},
//            new int[] {7, 8, 9}
//       };

//SetZeroes(matrix);

//// Print the modified matrix
//foreach (var row in matrix)
//{
//    Console.WriteLine(string.Join(" ", row));
//}

