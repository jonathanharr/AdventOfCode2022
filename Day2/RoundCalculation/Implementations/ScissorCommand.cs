namespace Day2.RoundCalculation.Implementations;

public class ScissorCommand : PredictionBaseCommand
{
    public ScissorCommand(Response response) : base(response)
    {
    }

    public override int CalculateRound()
    {
        var responseValue = (int) _response;
        return responseValue switch
        {
            1 => Win(),
            2 => Loss(),
            3 => Draw(),
            _ => 0
        };
    }

    public int Test(char response)
    {
        return response switch
        {
            'A' => Result(0),
            'B' => Result(6),
            'C' => Result(3),
            _ => 0
        };
    }
}