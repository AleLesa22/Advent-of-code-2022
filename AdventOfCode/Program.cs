﻿internal class Program
{
    private static void Main(string[] args)
    {
        var lines = File.ReadLines(@"C:\Users\avidakovic\Desktop\keynotes.txt");
        List<char> chars = new List<char>();

        foreach (var line in lines)
        {
            for (int i = 0; i < line.Length; i++)
            {
                chars.Add(line[i]);
            }

            for (int o = 0; o < chars.Count; o++)
            {
                char a = chars[o];
                char b = chars[o + 1];
                char c = chars[o + 2];
                char d = chars[o + 3];

                char e = chars[o + 4];
                char f = chars[o + 5];
                char g = chars[o + 6];
                char h = chars[o + 7];

                char i = chars[o + 8];
                char j = chars[o + 9];
                char k = chars[o + 10];
                char l = chars[o + 11];

                char m = chars[o + 12];
                char n = chars[o + 13];
                if ((a == b || a == c || a == d || a == e || a == f || a == g || a == h || a == i || a == j || a == k || a == l || a == m || a == n ||
                        b == c || b == d || b == e || b == f || b == g || b == h || b == i || b == j || b == k || b == l || b == m || b == n ||
                        c == d || c == e || c == f || c == g || c == h || c == i || c == j || c == k || c == l || c == m || c == n ||
                        d == e || d == f || d == g || d == h || d == i || d == j || d == k || d == l || d == m || d == n ||
                        e == f || e == g || e == h || e == i || e == j || e == k || e == l || e == m || e == n ||
                        f == g || f == h || f == i || f == j || f == k || f == l || f == m || f == n ||
                        g == h || g == i || g == j || g == k || g == l || g == m || g == n ||
                        h == i || h == j || h == k || h == l || h == m || h == n ||
                        i == j || i == k || i == l || i == m || i == n ||
                        j == k || j == l || j == m || j == n ||
                        k == l || k == m || k == n ||
                        l == m || l == n ||
                        m == n))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(o + 13 + 1);
                    break;
                }
            }
        }
        Console.ReadLine();
    }
}