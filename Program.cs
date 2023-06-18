using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankSolutions
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //DIAGONAL DIFFERENCE
      //DiagonalDifference matriceDifference = new DiagonalDifference();
      //matriceDifference.WriteDiagonalMatrice();
      //Console.WriteLine(matriceDifference.CalculateDiagonalDifference());

      //COUNTING SORT
      CountingSort sort = new CountingSort();
      //var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
      List<int> listArray = new List<int>() { 73, 57, 49, 99, 133, 20, 1 }; 
      sort._numberArray = listArray;
      sort.CountingSortMethod(sort._numberArray);




    }
  }
}
