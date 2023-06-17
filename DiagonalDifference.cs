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
      int right = 0;
      int left = 0;
      int result = 0;

      for (int i = 0; i < matrice.Count; i++)
      {
        for (int j = 0; j < matrice.Count; j++)
        {
          right = matrice[0][0] + matrice[1][1] + matrice[2][2];
          left = matrice[2][0] + matrice[1][1] + matrice[0][2];
        }

        result = Math.Abs(right - left);
      }

      return result;
    }
  }
}
