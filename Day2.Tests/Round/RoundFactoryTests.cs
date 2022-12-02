using Day2.RoundCalculation;
using Day2.RoundCalculation.Implementations;
using FluentAssertions;

namespace Day2.Tests.Round;

[TestClass]
public class RoundFactoryTests
{
    private const char OpponentRock = 'A';
    private const char OpponentPaper = 'B';
    private const char OpponentScissor = 'C';
    
    private const char ResponseRock = 'X';
    private const char ResponsePaper = 'Y';
    private const char ResponseScissor = 'Z';
    
    private IOutcomeOfRoundFactory _predictedOutcomeRoundFactory;

    [TestInitialize]
    public void Init()
    {
        _predictedOutcomeRoundFactory = new PredictedOutcomeRoundFactory();
    }
    
    [TestMethod]
    public void Rock_should_beat_Scissor_and_give_7()
    {
        var result = _predictedOutcomeRoundFactory.CalculateRound(OpponentScissor, ResponseRock);
        result.Should().Be(7);
    }
    
    [TestMethod]
    public void Paper_should_beat_Rock_and_give_8()
    {
        var result = _predictedOutcomeRoundFactory.CalculateRound(OpponentRock, ResponsePaper);
        result.Should().Be(8);
    }

    [TestMethod]
    public void Scissor_should_beat_Paper_and_give_9()
    {
        var result = _predictedOutcomeRoundFactory.CalculateRound(OpponentPaper, ResponseScissor);
        result.Should().Be(9);
    }

    [TestMethod]
    public void Rock_should_lose_to_Paper_and_give_1()
    {
        var result = _predictedOutcomeRoundFactory.CalculateRound(OpponentPaper, ResponseRock);
        result.Should().Be(1);
    }
    
    [TestMethod]
    public void Paper_should_lose_to_Scissor_and_give_2()
    {
        var result = _predictedOutcomeRoundFactory.CalculateRound(OpponentScissor, ResponsePaper);
        result.Should().Be(2);
    }
    
    [TestMethod]
    public void Scissor_should_lose_to_Rock_and_give_1()
    {
        var result = _predictedOutcomeRoundFactory.CalculateRound(OpponentRock, ResponseScissor);
        result.Should().Be(3);
    }
}