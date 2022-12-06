namespace Day5;

public class Crane
{
    private List<string> _instructions;

    public Crane()
    {
        _instructions = new List<string>();
    }

    public void InitializeInstructions(IEnumerable<string> instructions)
    {
        foreach (var row in instructions.Where(row => row.Contains("move")))
        {
            _instructions.Add(row);
        }
    }

    public void PerformStuff(Action<int, int, int> amountOfCratesMoveFromTo)
    {
        foreach (var row in _instructions)
        {
            
            var instruction = row.Split(' ');
            var amountToMove = Convert.ToInt32(instruction[1]);
            var moveFrom = Convert.ToInt32(instruction[3]);
            var moveTo = Convert.ToInt32(instruction[5]);
            amountOfCratesMoveFromTo(amountToMove, moveFrom, moveTo);
        }
        Console.WriteLine("END");
    }
}