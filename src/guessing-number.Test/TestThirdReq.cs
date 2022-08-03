using Xunit;
using System.IO;
using System;
using Moq;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestThirdReq
{
    [Theory(DisplayName = "Deve receber a executar o fluxo completo do programa")]
    [InlineData(new object[] {new string[]{"10"}, 10})]
    public void TestFullFlow(string[] entrys, int mockValue)
    {
        GuessNumber Game = new();
        Game.response = entrys[0];
        Game.Greet();        
        Game.RandomNumber();
        Game.randomValue = mockValue;;
        do
        {
            Game.ChooseNumber();
            Game.AnalyzePlay();
        }while(Game.randomValue != Game.userValue);
        Game.randomValue.Should().Be(10);     
        }
}