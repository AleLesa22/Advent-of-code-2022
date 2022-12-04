﻿internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\avidakovic\Desktop\keynotes.txt");

        int result = 0;

        Console.WriteLine("Contents of Rucksack.txt = ");


        foreach (string line in lines)
        {
            var firstElf = line.Split(',')[0];
            var secondElf = line.Split(',')[1];

            int startingSectionOfFirstElf = int.Parse(firstElf.Split('-')[0]);
            int endSectionOfFirstElf = int.Parse(firstElf.Split('-')[1]);

            int startingSectionOfSecondElf = int.Parse(secondElf.Split('-')[0]);
            int endSectionOfSecondElf = int.Parse(secondElf.Split('-')[1]);

            if (startingSectionOfFirstElf <= endSectionOfSecondElf && endSectionOfFirstElf >= startingSectionOfSecondElf)
            {
                result++;
            }
        }

        Console.WriteLine(result);
        Console.ReadLine();
    }
}