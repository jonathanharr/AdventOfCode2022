namespace Day2.RoundCalculation;

public interface IOutcomeOfRoundFactory
{
    public int CalculateRound(char opponentDraw, char response);
}