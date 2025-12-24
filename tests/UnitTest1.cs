using System.Reflection;
using Microsoft.VisualBasic;

namespace tests;

public class UnitTest1
{
    [Fact]
    public void password_should_be_3()
    {
        var absolutePath = new FileInfo("day1part1.txt").FullName;

        Day1 d1p1 = new Day1(absolutePath);
        var result = d1p1.SolvePart1();

        Assert.Equal(3, result);
    }

    [Fact]
    public void password_should_be_6()
    {
        var absolutePath = new FileInfo("day1part1.txt").FullName;
        Day1 d1p2 = new Day1(absolutePath);
        var result = d1p2.SolvePart2();

        Assert.Equal(6, result);
    }
}
