using System.IO.Pipelines;
using Microsoft.VisualBasic;

namespace tests;

public class UnitTest1
{
    [Fact]
    public void password_should_be_3()
    {
        string filePath = "Inputs/day1part1.txt";
        Day1Part1 d1p1 = new Day1Part1();
        var result = d1p1.SolveDay1Part1(filePath);
        Console.WriteLine(result);

        Assert.Equal(3, result);
    }
}
