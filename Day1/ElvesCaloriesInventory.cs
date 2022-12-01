using System.Linq.Expressions;

namespace Day1;

public class ElvesCaloriesInventory
{
    private readonly string _inventoryDocument;
    private List<int> _summedCaloriesHeldByElves;
    
    public ElvesCaloriesInventory(string inventoryDocument)
    {
        _inventoryDocument = inventoryDocument;
        _summedCaloriesHeldByElves = new List<int>();
    }
    
    public List<int> GetSortedCaloriesByElves()
    {
        var caloriesByThisElf = 0;
        foreach (var line in File.ReadAllLines(_inventoryDocument))
        {
            if (string.IsNullOrEmpty(line))
            {
                _summedCaloriesHeldByElves.Add(caloriesByThisElf);
                caloriesByThisElf = 0;
                continue;
            }

            caloriesByThisElf += Convert.ToInt32(line);
        }

        return _summedCaloriesHeldByElves;
    }
}