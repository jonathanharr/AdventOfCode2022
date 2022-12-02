namespace Day2.RoundCalculation.Implementations;

public class LoseCommand : StagedBaseCommand
{
    public LoseCommand(char opponentDraw) : base(opponentDraw)
    {
    }

    public override int CalculateRound()
    {
        DesiredOutcomeScore = 0;
        return OpponentDraw switch
        {
            'A' => Scissor(),
            'B' => Rock(),
            'C' => Paper(),
            _ => 0
        };
    }
}