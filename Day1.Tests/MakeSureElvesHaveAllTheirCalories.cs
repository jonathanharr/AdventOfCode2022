using FluentAssertions;

namespace Day1.Tests;

[TestClass]
public class MakeSureElvesHaveAllTheirCalories
{
    private const int AmountOfElves = 234;
    
    private ElvesCaloriesInventory _textReader;
    private List<int> _caloriesByElf;
    
    [TestInitialize]
    public void Init()
    {
        _textReader = new ElvesCaloriesInventory("Inventory/input.txt");
        _caloriesByElf = _textReader.GetSortedCaloriesByElves();
    }
    
    [TestMethod]
    public void Should_contain_calories_summed_by_each_elf()
    {
        _caloriesByElf.Should().NotBeNull();
    }

    [TestMethod]
    public void Should_have_234_elves_carrying_calories()
    {
        _caloriesByElf.Count.Should().Be(AmountOfElves);
    }
}