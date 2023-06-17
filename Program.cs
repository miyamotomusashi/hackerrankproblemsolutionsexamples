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

      DiagonalDifference matriceDifference = new DiagonalDifference();
      matriceDifference.WriteDiagonalMatrice();
      Console.WriteLine(matriceDifference.CalculateDiagonalDifference());


    }
  }
}
