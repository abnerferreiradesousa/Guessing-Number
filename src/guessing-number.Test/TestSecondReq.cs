using Xunit;
using System.IO;
using System;
using Moq;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestSecondReq
{
    [Theory(DisplayName = "Deve escolher randomicamente um número entre -100 e 100!")]
    [InlineData(-100, 100)]
    public void TestRandomlyChooseANumber(int MinimumRange, int MaximumRange)
    {
        var instance = new GuessNumber();
        instance.RandomNumber();
        instance.randomValue.Should().BeLessThanOrEqualTo(MaximumRange);
        instance.randomValue.Should().BeGreaterThanOrEqualTo(MinimumRange);
    }

    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MENOR")]
    [InlineData(50, 0)]
    public void TestProgramComparisonValuesLess(int mockValue, int entry)
    {
        using (var NewOutput = new StringWriter())
        {
        Console.SetOut(NewOutput);

        var instance = new GuessNumber();

        instance.userValue = mockValue;
        instance.randomValue = entry;
        string result = NewOutput.ToString().Trim();
        instance.AnalyzePlay();
        var output = NewOutput.ToString();
        output.Should().Be("Tente um número MENOR");
        }
        // var stringReader = new StringReader(mockValue.ToString());
	    // Console.SetIn(stringReader);
  
    }
    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MAIOR")]
    [InlineData(50, 60)]
    public void TestProgramComparisonValuesBigger(int mockValue, int entry)
    {
        using (var NewOutput = new StringWriter())
        {
        Console.SetOut(NewOutput);

        var instance = new GuessNumber();

        instance.userValue = entry;
        instance.randomValue = mockValue;
        string result = NewOutput.ToString().Trim();
        instance.AnalyzePlay();
        var output = NewOutput.ToString();
        output.Should().Be("Tente um número MAIOR");
        }
        // throw new NotImplementedException();  
    }
    
    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MAIOR")]
    [InlineData(50, 50)]
    public void TestProgramComparisonValuesEqual(int mockValue, int entry)
    {
       using (var NewOutput = new StringWriter())
        {
        Console.SetOut(NewOutput);

        var instance = new GuessNumber();

        instance.userValue = entry;
        instance.randomValue = mockValue;
        string result = NewOutput.ToString().Trim();
        instance.AnalyzePlay();
        var output = NewOutput.ToString();
        output.Should().Be("ACERTOU!");
        }    
    }    
}