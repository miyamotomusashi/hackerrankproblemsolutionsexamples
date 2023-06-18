﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
  
  public class CountingSort
  {
    public List<int> _numberArray { get; set; } = new List<int>();
    public CountingSort() { }


    public int GetMaxVal(List<int> array, int size)
    {
      var maxVal = array[0];
      for (int i = 1; i < size; i++)
        if (array[i] > maxVal)
          maxVal = array[i];
      return maxVal;
   }

    public void CountingSortMethod(List<int> array)
    {
      var size = array.Count();
      var maxElement = GetMaxVal(array, size);
      var occurrences = new int[maxElement + 1];
      for (int i = 0; i < maxElement + 1; i++)
      {
        occurrences[i] = 0;
      }
      for (int i = 0; i < size; i++)
      {
        occurrences[array[i]]++;
      }
      for (int i = 0, j = 0; i <= maxElement; i++)
      {
        while (occurrences[i] > 0)
        {
          array[j] = i;
          j++;
          occurrences[i]--;
        }
      }

      foreach (int i in array)
      {
        Console.Write(i + ",");
      }
      //return array;
    }

  }


}
