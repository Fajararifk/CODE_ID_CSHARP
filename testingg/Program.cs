using System;
public class Program
{
    //Checks for the largest common prefix  
    public static String lcp(String s, String t)
    {
        int n = Math.Min(s.Length, t.Length);
        for (int i = 0; i < n; i++)
        {
            if (s[i] != t[i])
            {
                return s.Substring(0, i);
            }
        }
        return s.Substring(0, n);
    }

    public static void Main()
    {
        String str = "acbdfghybdf";
        String lrs = "";
        int n = str.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n - i; j++)
            {
                //Checks for the largest common factors in every substring  
                String x = lcp(str.Substring(i), str.Substring(j));
                //If the current prefix is greater than previous one   
                //then it takes the current one as longest repeating sequence  
                if (x.Length > lrs.Length) lrs = x;
            }
        }
        Console.WriteLine("Longest repeating sequence: " + lrs);
    }
}