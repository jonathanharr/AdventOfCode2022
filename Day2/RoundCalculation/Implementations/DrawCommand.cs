namespace Day2.RoundCalculation.Implementations;

public class DrawCommand : StagedBaseCommand
{
    public DrawCommand(char opponentDraw) : base(opponentDraw)
    {
    }

    public override int CalculateRound()
    {
        DesiredOutcomeScore = 3;
        return OpponentDraw switch
        {
            'A' => Rock(),
            'B' => Paper(),
            'C' => Scissor(),
            _ => 0
        };
    }
}