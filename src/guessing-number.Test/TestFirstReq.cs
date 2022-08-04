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
    [InlineData(new object[] {new string[]{
        "---Bem-vindo ao Guessing Game---", 
        "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!"}})]
    public void TestPrintInitialMessage(string[] expected)
    {
       using(var stringWriter = new StringWriter())
        {     
            Console.SetOut(stringWriter); 
            var instance = new GuessNumber(); 
            instance.Greet();        
            int count = 0;
            var response = stringWriter.ToString().Trim();
            while (count < expected.Length)
            {
            response.Should().Contain(expected[count]);                                                
            count++;
            }
        }
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e converter para int")]
    [InlineData("0", 0)]
    public void TestReceiveUserInputAndConvert(string entry, int expected)
    {    
        using(var stringWriter = new StringWriter())
        {
            using(var stringReader = new StringReader(String.Join("\n", entry))) 
            {      
                Console.SetOut(stringWriter); 
                Console.SetIn(stringReader);                                     

                var instance = new GuessNumber(); 
                instance.ChooseNumber();                                    
                
                var response = stringWriter.ToString().Trim();                   
                instance.userValue.Should().Be(expected);                                                 
            }          
        }
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que é um numérico")]
    [InlineData(new object[] {new string[]{"10,", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyType(string[] entrys, int expected)
    {
        using(var stringWriter = new StringWriter())
        {
            using(var stringReader = new StringReader(String.Join("\n", entrys[0], entrys[1]))) 
            {      
                Console.SetOut(stringWriter); 
                Console.SetIn(stringReader);                                     

                var instance = new GuessNumber(); 
                instance.ChooseNumber();                                    
                
                var response = stringWriter.ToString().Trim();
                response.Should().Contain("Por favor, digite um número inteiro");                                                 

                instance.userValue.Should().Be(expected);                                                 
            }          
        } 
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que está entre -100 e 100!")]
    [InlineData(new object[] {new string[]{"1000", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyRange(string[] entrys, int expected)
    {
        using(var stringWriter = new StringWriter())
        {
            using(var stringReader = new StringReader(String.Join("\n", entrys[0], entrys[1]))) 
            {      
                Console.SetOut(stringWriter); 
                Console.SetIn(stringReader);                                     

                var instance = new GuessNumber(); 
                instance.ChooseNumber();                                    
                
                var response = stringWriter.ToString().Trim();
                response.Should().Contain("Por favor, digite um número inteiro");                                                 

                instance.userValue.Should().Be(expected);                                                 
            }          
        } 
    }    
}