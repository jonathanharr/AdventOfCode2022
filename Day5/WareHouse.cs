using System.Text.RegularExpressions;

namespace Day5;

public class WareHouse
{
    private Dictionary<int, List<char>> _wares;
    private List<string> _rows;

    private Crane _crane;
    
    public WareHouse(List<string> rows, Crane crane)
    {
        _rows = rows;
        _crane = crane;
    }

    private void SetCrateColumns()
    {
        _wares = new Dictionary<int, List<char>>();
        var amountOfColumns = (_rows[0].Length + 1) / 4;
        for (var i = 1; i <= amountOfColumns; i++)
        {
            _wares.Add(i, new List<char>());
        }
    }
    
    public void InitializeCrates()
    {
        SetCrateColumns();
        foreach (var row in _rows)
        {
            if (Regex.IsMatch(row, "/[0-9]/"))
            {
                break;
            }

            var columnIndex = 1;
            for (var i = 1; i < row.Length; i++)
            {
                if (i % 4 == 1 || i == 1)
                {
                    if (Regex.IsMatch(row[i].ToString(), "[A-Z]"))
                    {
                        _wares[columnIndex].Insert(0, row[i]);
                    }

                    columnIndex +=1;
                }
            }
        }
    }

    public void PerformLogisticsForTheElves()
    {
        _crane.PerformStuff(MoveSequenceOfCratesFromTo);
    }

    private void MoveCratesFromTo(int amountToMove, int moveFrom, int moveTo)
    {
        Console.WriteLine($"move {amountToMove} from {moveFrom} to {moveTo}");
        for (var i = 1; i <= amountToMove; i++)
        {
            var pileToMoveFrom = _wares[moveFrom];
            var crateToMove = pileToMoveFrom[^1];
            _wares[moveFrom].RemoveAt(pileToMoveFrom.Count - 1);
            _wares[moveTo].Add(crateToMove);
        }
    }

    private void MoveSequenceOfCratesFromTo(int amountToMove, int moveFrom, int moveTo)
    {
        Console.WriteLine($"move {amountToMove} from {moveFrom} to {moveTo}");
        var pileToMoveFrom = _wares[moveFrom];
        var cratesToMove = pileToMoveFrom.GetRange(pileToMoveFrom.Count - amountToMove, amountToMove);
        _wares[moveFrom].RemoveRange(pileToMoveFrom.Count - amountToMove, amountToMove);
        _wares[moveTo].AddRange(cratesToMove);
    }
    
    public string GetTopShelfCrates()
    {
        return _wares.Aggregate("", (current, cratePile) => current + cratePile.Value.Last());
    }
}