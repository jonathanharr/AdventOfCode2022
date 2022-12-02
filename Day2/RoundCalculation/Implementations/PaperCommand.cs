namespace Day2.RoundCalculation.Implementations;

public class PaperCommand : PredictionBaseCommand
{
    public PaperCommand(Response response) : base(response)
    {
    }

    public override int CalculateRound()
    {
        var responseValue = (int) _response;
        return responseValue switch
        {
            1 => Loss(),
            2 => Draw(),
            3 => Win(),
            _ => 0
        };
    }
}