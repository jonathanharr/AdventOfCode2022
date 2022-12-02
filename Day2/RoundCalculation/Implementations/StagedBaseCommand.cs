namespace Day2.RoundCalculation.Implementations;

public abstract class StagedBaseCommand : IRockPaperScissorsCommand
{
    protected char OpponentDraw;
    protected int DesiredOutcomeScore;

    protected StagedBaseCommand(char opponentDraw)
    {
        OpponentDraw = opponentDraw;
    }

    public abstract int CalculateRound();

    protected int Rock()
    {
        return 1 + DesiredOutcomeScore;
    }

    protected int Paper()
    {
        return 2 + DesiredOutcomeScore;
    }

    protected int Scissor()
    {
        return 3 + DesiredOutcomeScore;
    }
}