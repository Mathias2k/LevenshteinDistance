namespace Levenshtein_Distance
{
   internal class Program
   {
      static void Main()
      {
         string pinned = "THE BROWN FOX JUMPED OVER THE RED COW";
         string string1 = "THE RED COW JUMPED OVER THE GREEN CHICKEN";
         string string2 = "THE RED COW JUMPED OVER THE RED COW";
         string string3 = "THE RED FOX JUMPED OVER THE BROWN COW";

         Console.WriteLine(StringDistance.LevenshteinDistance(pinned, string1));
         Console.WriteLine(StringDistance.LevenshteinDistance(pinned, string2));
         Console.WriteLine(StringDistance.LevenshteinDistance(pinned, string3));
      }
   }

   public static class StringDistance
   {
      /// <summary>
      /// Compute the distance between two strings.
      /// </summary>
      public static int LevenshteinDistance(string s, string t)
      {
         int n = s.Length;
         int m = t.Length;
         int[,] d = new int[n + 1, m + 1];

         // Step 1
         if (n == 0)
         {
            return m;
         }

         if (m == 0)
         {
            return n;
         }

         // Step 2
         for (int i = 0; i <= n; d[i, 0] = i++)
         {
         }

         for (int j = 0; j <= m; d[0, j] = j++)
         {
         }

         // Step 3
         for (int i = 1; i <= n; i++)
         {
            //Step 4
            for (int j = 1; j <= m; j++)
            {
               // Step 5
               int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

               // Step 6
               d[i, j] = Math.Min(
                   Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                   d[i - 1, j - 1] + cost);
            }
         }
         // Step 7
         return d[n, m];
      }
   }
}