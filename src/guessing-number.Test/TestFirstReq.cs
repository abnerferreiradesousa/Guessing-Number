using Xunit;
using System.IO;
using System;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Theory(DisplayName = "Deve exibir mensagem inicial!")]
    [InlineData(new object[] {new string[]{"---Bem-vindo ao ...---", "Para começar..."}})]
    public void TestPrintInitialMessage(string[] expected)
    {
        using (var NewOutput = new StringWriter())
        {
        Console.SetOut(NewOutput);

        GuessNumber instance = new();
        instance.Greet();

        string result = NewOutput.ToString().Trim();
        result.Should().Be("expected");
        }      
        // throw new NotImplementedException();  

    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e converter para int")]
    [InlineData("0", 0)]
    public void TestReceiveUserInputAndConvert(string entry, int expected)
    {        
        GuessNumber instance = new();
        instance.response = entry;
        instance.ChooseNumber();
        instance.userValue.Should().Be(expected);
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que é um numérico")]
    [InlineData(new object[] {new string[]{"10,", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyType(string[] entrys, int expected)
    {

        // throw new NotImplementedException();  

        var consoleValueInsert = new StringReader(entrys[0].ToString());
        Console.SetIn(consoleValueInsert);
        var instance = new GuessNumber();
        instance.response.Should().Be(expected.ToString());  
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que está entre -100 e 100!")]
    [InlineData(new object[] {new string[]{"1000", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyRange(string[] entrys, int expected)
    {
        // throw new NotImplementedException();  

        Console.Write(entrys);
        var consoleValueInsert = new StringReader(entrys.ToString());
            Console.SetIn(consoleValueInsert);
            var instance = new GuessNumber();
            instance.response.Should().Be(expected.ToString());
    }    
}