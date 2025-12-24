using System;

public class Day1Part1
{
    private int startingPosition;
    private int currentPosition;
    private int password;

    public Day1Part1()
    {
        startingPosition = 50;
        currentPosition = startingPosition;
        password = 0;
    }

    private List<string> ReadEntireFile(string path)
    {
        List<string> FileContents = new List<string>();

        try
        {
            FileContents = [.. File.ReadAllLines(path)];
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }

        return FileContents;
    }

    public int SolveDay1Part1(string FilePath)
    {
        var fileLines = ReadEntireFile(FilePath);

        foreach (var line in fileLines)
        {
            if (line[0] == 'L')
            {
                currentPosition -= int.Parse(line[1..]);
                var currentPositionModulo = currentPosition % 100;

                if (currentPositionModulo == 0)
                {
                    password += 1;
                }
            }
            else
            {
                currentPosition += int.Parse(line[1..]);
                var currentPositionModulo = currentPosition % 100;

                if (currentPositionModulo == 0)
                {
                    password += 1;
                }
            }
        }

        return password;
    }
}