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
    [InlineData()]
    public void TestRandomlyChooseANumber(int MinimumRange, int MaximumRange)
    {
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MENOR")]
    [InlineData()]
    public void TestProgramComparisonValuesLess(int mockValue, int entry)
    {
        throw new NotImplementedException();   
    }
    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MAIOR")]
    [InlineData()]
    public void TestProgramComparisonValuesBigger(int mockValue, int entry)
    {
        throw new NotImplementedException();  
    }
    
    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MAIOR")]
    [InlineData()]
    public void TestProgramComparisonValuesEqual(int mockValue, int entry)
    {
        throw new NotImplementedException();
    }    
}