namespace Day2.Match;

public class StrategyReader
{
    private readonly string _inventoryDocument;

    public StrategyReader(string inventoryDocument)
    {
        _inventoryDocument = inventoryDocument;
    }

    public List<string> GetStrategyRoundsPerList()
    {
        return File.ReadAllLines(_inventoryDocument).ToList();
    }
}