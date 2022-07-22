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
    [InlineData()]
    public void TestPrintInitialMessage(string[] expected)
    {
        throw new NotImplementedException();                                                   
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e converter para int")]
    [InlineData()]
    public void TestReceiveUserInputAndConvert(string entry, int expected)
    {        
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que é um numérico")]
    [InlineData()]
    public void TestReceiveUserInputAndVerifyType(string[] entrys, int expected)
    {
        throw new NotImplementedException();  
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que está entre -100 e 100!")]
    [InlineData()]
    public void TestReceiveUserInputAndVerifyRange(string[] entrys, int expected)
    {
        throw new NotImplementedException();
    }    
}