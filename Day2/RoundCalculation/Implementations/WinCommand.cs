namespace Day2.RoundCalculation.Implementations;

public class WinCommand : StagedBaseCommand
{
    public WinCommand(char opponentDraw) : base(opponentDraw)
    {
    }

    public override int CalculateRound()
    {
        DesiredOutcomeScore = 6;
        return OpponentDraw switch
        {
            'A' => Paper(),
            'B' => Scissor(),
            'C' => Rock(),
            _ => 0
        };
    }
}