namespace Day2.RoundCalculation.Implementations;

public abstract class PredictionBaseCommand : IRockPaperScissorsCommand
{
    protected Response _response;

    protected PredictionBaseCommand(Response response)
    {
        _response = response;
    }
    
    public abstract int CalculateRound();

    protected int Win()
    {
        return 6 + (int) _response;
    }
    
    protected int Draw()
    {
        return 3 + (int) _response;
    }

    protected int Loss()
    {
        return 0 + (int) _response;
    }

    protected int Result(int option)
    {
        return option + (int) _response;
    }
}