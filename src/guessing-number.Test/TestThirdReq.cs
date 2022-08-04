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
        // Pedir ajuda pra testar essa último método!
        
        using(var stringWriter = new StringWriter())
        {
            using(var stringReader = new StringReader(String.Join("\n", entrys[0]))) 
            {      
                Console.SetOut(stringWriter); 
                Console.SetIn(stringReader);                                     

                var instance = new GuessNumber(); 
                instance.Greet();                                    
                instance.ChooseNumber();                                    
                instance.randomValue = mockValue;                                    
                
                var response = stringWriter.ToString().Trim();                   
                response.Should().Contain("ACERTOU!");                                                 
            }          
        }
    }
}