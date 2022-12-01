namespace Day1;

public class ElvesCaloriesAnalyzer
{
    private ElvesCaloriesInventory _elvesCaloriesInventory;
    private List<int> _summedCaloriesHeldByElves;
    
    public ElvesCaloriesAnalyzer()
    {
        _elvesCaloriesInventory = new ElvesCaloriesInventory("Inventory/input.txt");
        _summedCaloriesHeldByElves = _elvesCaloriesInventory.GetSortedCaloriesByElves();
    }
    
    public int GetHighestCaloriesAmountHeldByElf()
    {
        return _summedCaloriesHeldByElves.Max();
    }

    public int GetHighestCaloriesAmountHeldByTop3Elves()
    {
        return _summedCaloriesHeldByElves
            .OrderByDescending(calories => calories).Take(3).Sum();
    }
}