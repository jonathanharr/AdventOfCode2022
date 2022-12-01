using FluentAssertions;

namespace Day1.Tests;

[TestClass]
public class TotalSumOfTopThreeElvesTests
{
    private const int ExpectedAmountOfTopThreeElves = 207410;
    
    private ElvesCaloriesAnalyzer _elvesCaloriesAnalyzer;
    private int _caloriesAmountOfTopThreeElves;

    [TestInitialize]
    public void Init()
    {
        _elvesCaloriesAnalyzer = new ElvesCaloriesAnalyzer();
        _caloriesAmountOfTopThreeElves = _elvesCaloriesAnalyzer.GetHighestCaloriesAmountHeldByTop3Elves();
    }

    [TestMethod]
    public void Should_equal_217806()
    {
        _caloriesAmountOfTopThreeElves.Should().Be(ExpectedAmountOfTopThreeElves);
    }
}