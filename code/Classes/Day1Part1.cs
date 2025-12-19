using System;

public class Day1Part1
{
    public string ReadFile()
    {
        StreamReader sr = new StreamReader("code/Input/day1part1.txt");

        string line = "";

        try
        {
            line = sr.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }

        return line;
    }

}