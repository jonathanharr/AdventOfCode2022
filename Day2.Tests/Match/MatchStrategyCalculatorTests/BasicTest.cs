using Day2.Match;
using Day2.RoundCalculation.Implementations;
using FluentAssertions;

namespace Day2.Tests.Match.MatchStrategyCalculatorTests;

[TestClass]
public class BasicTest
{
    private const int ExpectedPredictedPoints = 15;
    private const int ExpectedDesiredPoints = 12;
    
    private MatchStrategyCalculator _matchStrategyCalculator;

    private List<string> _suggestedRounds= new()
    {
        "A Y", "B X", "C Z"
    };

    [TestInitialize]
    public void Init()
    {
        _matchStrategyCalculator = new MatchStrategyCalculator(new PredictedOutcomeRoundFactory());
    }

    [TestMethod]
    public void Predicted_strategy_should_give_15_points()
    {
        _matchStrategyCalculator = new MatchStrategyCalculator(new PredictedOutcomeRoundFactory());
        var result = _matchStrategyCalculator.GetTotalScoreFromStrategy(_suggestedRounds);
        result.Should().Be(ExpectedPredictedPoints);
    }

    [TestMethod]
    public void Desired_strategy_should_give_12_points()
    {
        _matchStrategyCalculator = new MatchStrategyCalculator(new StagedOutcomeRoundFactory());
        var result = _matchStrategyCalculator.GetTotalScoreFromStrategy(_suggestedRounds);
        result.Should().Be(ExpectedDesiredPoints);
    }
}