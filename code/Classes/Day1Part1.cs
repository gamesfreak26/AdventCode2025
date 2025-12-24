using System;

public class Day1Part1
{
    private int StartingPosition;
    private int CurrentPosition;
    private int Password;
    private string Path;

    public Day1Part1(string FilePath)
    {
        StartingPosition = 50;
        CurrentPosition = StartingPosition;
        Password = 0;
        Path = FilePath;
    }

    public int SolveDay1Part1()
    {
        InputReader inputReader = new InputReader(Path);
        var fileLines = inputReader.ReadEntireFile();

        foreach (var line in fileLines)
        {
            if (line[0] == 'L')
            {
                CurrentPosition -= int.Parse(line[1..]);
                var currentPositionModulo = CurrentPosition % 100;

                if (currentPositionModulo == 0)
                {
                    Password += 1;
                }
            }
            else
            {
                CurrentPosition += int.Parse(line[1..]);
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