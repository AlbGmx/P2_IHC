

using System;

internal class Program
{
   private static void Main(string[] args)
   {
      int[] array = { 2,7,11,15 };
      int target = 18;
      int[] result = SumaDos(array, target);
      Console.WriteLine("The indexes are: {0} and {1}", result[0], result[1]);
   }

   private static int[] SumaDos(int[] nums, int target)
   {
      int[] result = new int[2];
      for (int i = 0; i < nums.Length; i++)
      {
         for (int j = i + 1; j < nums.Length; j++)
         {
            if (nums[i] + nums[j] == target)
            {
               result[0] = i;
               result[1] = j;
               return result;
            }
         }
      }
      return result;
   }
}

//Complejidad en tiempo: O(n^2)
//En espacio: O(1)