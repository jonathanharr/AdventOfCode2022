using Day2.RoundCalculation;

namespace Day2.Match;

public class MatchStrategyCalculator
{
    private IOutcomeOfRoundFactory _predictedOutcomeRoundFactory;
    
    public MatchStrategyCalculator(IOutcomeOfRoundFactory predictedOutcomeRoundFactory)
    {
        _predictedOutcomeRoundFactory = predictedOutcomeRoundFactory;
    }

    public int GetTotalScoreFromStrategy(IEnumerable<string> suggestedStrategyRounds)
    {
        return suggestedStrategyRounds.Sum(round => 
            _predictedOutcomeRoundFactory.CalculateRound(round[0], round[2]));
    }
}