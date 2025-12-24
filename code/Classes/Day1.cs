using System;

public class Day1
{
    private int StartingPosition;
    private int CurrentPosition;
    private int Password;
    private string Path;

    public Day1(string FilePath)
    {
        StartingPosition = 50;
        CurrentPosition = StartingPosition;
        Password = 0;
        Path = FilePath;
    }

    private List<string> readFile()
    {
        InputReader inputReader = new InputReader(Path);
        var fileLines = inputReader.ReadEntireFile();
        return fileLines;
    }

    public int SolvePart1()
    {
        var Lines = readFile();

        foreach (var Line in Lines)
        {
            if (Line[0] == 'L')
            {
                CurrentPosition -= int.Parse(Line[1..]);
                var currentPositionModulo = CurrentPosition % 100;

                if (currentPositionModulo == 0)
                {
                    Password += 1;
                }
            }
            else
            {
                CurrentPosition += int.Parse(Line[1..]);
                var currentPositionModulo = CurrentPosition % 100;

                if (currentPositionModulo == 0)
                {
                    Password += 1;
                }
            }
        }

        return Password;
    }

    public int SolvePart2()
    {
        var Lines = readFile();

        foreach (var Line in Lines)
        {
            if (Line[0] == 'L')
            {
                CurrentPosition -= int.Parse(Line[1..]);
                var currentPositionModulo = CurrentPosition % 100;

                if (currentPositionModulo == 0)
                {
                    Password += 1;
                }
            }
            else
            {
                CurrentPosition += int.Parse(Line[1..]);
                var currentPositionModulo = CurrentPosition % 100;

                if (currentPositionModulo == 0)
                {
                    Password += 1;
                }
            }
        }

        return Password;
    }
}