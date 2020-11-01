using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgoLab2.manager
{
  public class Utilities {
      public static void Swap(List<decimal> listToSwap, int firstIndex, int secondIndex)
      {
          decimal buffer = listToSwap[firstIndex];
          listToSwap[firstIndex] = listToSwap[secondIndex];
          listToSwap[secondIndex] = buffer;
      }
  } }
