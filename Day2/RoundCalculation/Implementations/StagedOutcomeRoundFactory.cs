namespace Day2.RoundCalculation.Implementations;

public class StagedOutcomeRoundFactory : IOutcomeOfRoundFactory
{
    private IRockPaperScissorsCommand _command;
    
    public int CalculateRound(char opponentDraw, char desiredOutcomeChar)
    {
        switch (desiredOutcomeChar)
        {
            case 'X':
                _command = new LoseCommand(opponentDraw);
                return _command.CalculateRound();
            case 'Y':
                _command = new DrawCommand(opponentDraw);
                return _command.CalculateRound();
            case 'Z':
                _command = new WinCommand(opponentDraw);
                return _command.CalculateRound();
        }

        return 0;
    }
}