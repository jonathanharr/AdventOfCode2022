namespace Day2.RoundCalculation.Implementations;

public class RockCommand : PredictionBaseCommand
{
    public RockCommand(Response response) : base(response)
    {
    }

    public override int CalculateRound()
    {
        var responseValue = (int) _response;
        return responseValue switch
        {
            1 => Draw(),
            2 => Win(),
            3 => Loss(),
            _ => 0
        };
    }
}