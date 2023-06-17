using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
  public class DiagonalDifference
  {
    List<List<int>> matrice = new List<List<int>>();
    public DiagonalDifference() {
      matrice.Add(new List<int>() { 6, 2, 3 });
      matrice.Add(new List<int>() { 1, 8, 2 });
      matrice.Add(new List<int>() { 3, 4, 7 });
    }

    public void WriteDiagonalMatrice()
    { 
      for(int i=0;i<matrice.Count();i++)
      {
        for (int j = 0; j < matrice[i].Count(); j++)
        {
          Console.Write(matrice[i][j] + " ");
        }
        Console.WriteLine();
      }
    }

    public int CalculateDiagonalDifference()
    {
      int sum = 0;
      int index = 0;
      int length = matrice.Count - 1;

      foreach(var item in matrice)
      {
        int temp = item[index] - item[length - index];
        sum += temp;index++;
      }
      return Math.Abs(sum);

    }
  }
}
