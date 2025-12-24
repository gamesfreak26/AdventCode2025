using System.Reflection;
using Microsoft.VisualBasic;

namespace tests;

public class UnitTest1
{
    [Fact]
    public void password_should_be_3()
    {
        var absolutePath = new FileInfo("day1part1.txt").FullName;

        Day1Part1 d1p1 = new Day1Part1();
        var result = d1p1.SolveDay1Part1(absolutePath);

        Assert.Equal(3, result);
    }

    [Fact]
    public void password_should_be_6()
    {
        var absolutePath = new FileInfo("day1part1.txt").FullName;
        Day1Part1 d1p1 = new Day1Part1();

        Assert.Equal(3, 6);
    }
}
