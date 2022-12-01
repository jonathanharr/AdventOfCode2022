using FluentAssertions;

namespace Day1.Tests;

[TestClass]
public class HighestCaloriesAmountHeldByElfTests
{
    private const int ExpectedCaloryAmount = 72602;
    
    private ElvesCaloriesAnalyzer _elvesCaloriesAnalyzer;
    private int _highestCaloryAmount;

    [TestInitialize]
    public void Init()
    {
        _elvesCaloriesAnalyzer = new ElvesCaloriesAnalyzer();
        _highestCaloryAmount = _elvesCaloriesAnalyzer.GetHighestCaloriesAmountHeldByElf();
    }
    
    [TestMethod]
    public void Top_elf_should_not_have_eaten_from_his_calories()
    {
        _highestCaloryAmount.Should().BePositive();
    }

    [TestMethod]
    public void Top_elf_should_carry_ExpectedCaloriesAmount_in_total()
    {
        _highestCaloryAmount.Should().Be(ExpectedCaloryAmount);
    }
}