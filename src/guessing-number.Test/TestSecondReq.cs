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
        using(var stringWriter = new StringWriter()) 
        {
            var instance = new GuessNumber();
            instance.userValue = mockValue;
            instance.randomValue = entry;

            Console.SetOut(stringWriter);
            instance.AnalyzePlay();

            var res = stringWriter.ToString().Trim();
            res.Should().Contain("Tente um número MENOR");
        }
    }
    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MAIOR")]
    [InlineData(50, 60)]
    public void TestProgramComparisonValuesBigger(int mockValue, int entry)
    {
        using(var stringWriter = new StringWriter()) 
        {
            var instance = new GuessNumber();
            instance.userValue = mockValue;
            instance.randomValue = entry;

            Console.SetOut(stringWriter);
            instance.AnalyzePlay();
            
            var res = stringWriter.ToString().Trim();
            res.Should().Contain("Tente um número MAIOR");
        } 
    }
    
    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso IGUAL")]
    [InlineData(50, 50)]
    public void TestProgramComparisonValuesEqual(int mockValue, int entry)
    {
        using(var stringWriter = new StringWriter()) 
        {
            var instance = new GuessNumber();
            instance.userValue = mockValue;
            instance.randomValue = entry;

            Console.SetOut(stringWriter);
            instance.AnalyzePlay();
            
            var res = stringWriter.ToString().Trim();
            res.Should().Contain("ACERTOU!");
        }

    }    
}