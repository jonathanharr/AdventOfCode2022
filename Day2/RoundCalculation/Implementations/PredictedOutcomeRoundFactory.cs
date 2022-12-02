namespace Day2.RoundCalculation.Implementations;

public class PredictedOutcomeRoundFactory : IOutcomeOfRoundFactory
{
    private IRockPaperScissorsCommand _command;
    
    public int CalculateRound(char opponentDraw, char response)
    {
        var responseEnum = (Response) Enum.Parse(typeof(Response), response.ToString());
        switch (opponentDraw)
        {
            case 'A':
                _command = new RockCommand(responseEnum);
                return _command.CalculateRound();
            case 'B':
                _command = new PaperCommand(responseEnum);
                return _command.CalculateRound();
            case 'C':
                _command = new ScissorCommand(responseEnum);
                return _command.CalculateRound();
        }

        return 0;
    }
}