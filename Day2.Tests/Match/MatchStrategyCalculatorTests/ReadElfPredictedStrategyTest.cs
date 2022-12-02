using Day2.Match;
using Day2.RoundCalculation.Implementations;
using FluentAssertions;

namespace Day2.Tests.Match.MatchStrategyCalculatorTests;

[TestClass]
public class ReadElfPredictedStrategyTest
{
    private const int ExpectedPoints = 12276;
    
    private MatchStrategyCalculator _matchStrategyCalculator;
    private StrategyReader _strategyReader;
    private List<string> _suggestedRounds;

    private int _resultingPoints;

    [TestInitialize]
    public void Init()
    {
        _matchStrategyCalculator = new MatchStrategyCalculator(new PredictedOutcomeRoundFactory());
        _suggestedRounds = new StrategyReader("Strategy/input.txt")
            .GetStrategyRoundsPerList();
        
        _resultingPoints = _matchStrategyCalculator
            .GetTotalScoreFromStrategy(_suggestedRounds);
    }

    [TestMethod]
    public void Should_equal_ExpectedAmount()
    {
        _resultingPoints.Should().Be(ExpectedPoints);
    }
}