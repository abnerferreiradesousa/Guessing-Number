using System;

namespace guessing_number;

public class GuessNumber
{    
    private IRandomGenerator random;    
    public GuessNumber() : this(new DefaultRandom()){}
    public GuessNumber(IRandomGenerator obj)
    {
        this.random = obj;
    }

    //user variables
    public string? response;
    public int userValue;
    public int randomValue;


    public void Greet()
    {
        Console.Write($"---Bem-vindo ao Guessing Game---\n");
        Console.Write(
            $"Para começar, tente adivinhar o número que eu pensei, entre -100 e 100! \n"
        );
        // var res = Console.ReadLine();
        // try {
        //     int convert = Convert.ToInt32(res);
        //     if(convert > 100 || convert < -100) 
        //     {
        //         Console.Write("Por favor, digite um número inteiro: \n");
        //         Greet();
        //     }
        //     response = res;
        // } catch(Exception error) {
        //     Console.WriteLine("Por favor, digite um número inteiro: \n");
        //     Greet();
        // }    
    }

    public void ChooseNumber()
    {
        var res = Console.ReadLine();
        try {
            int convert = Convert.ToInt32(res);
            if(convert > 100 || convert < -100) 
            {
                Console.Write("Por favor, digite um número inteiro: \n");
                ChooseNumber();
            }
            response = res;
            userValue = convert;
        } catch(Exception error) {
            Console.WriteLine("Por favor, digite um número inteiro: \n");
            Console.WriteLine(error);
            ChooseNumber();
        }   
        // int convert = Convert.ToInt32(response);
    }
    
    public void RandomNumber()
    {
        randomValue = random.GetInt(-100, 100);
    }
    
    public void AnalyzePlay()
    {
        if (userValue > randomValue)
        {
            Console.Write("Tente um número MENOR \n");
            // ChooseNumber();
        }
        if (userValue < randomValue) 
        {
            Console.Write("Tente um número MAIOR \n");
            // ChooseNumber();
        }
        if (userValue == randomValue) 
        {
            Console.WriteLine(userValue.ToString(), randomValue);
            Console.Write("ACERTOU!");
        }
    }
}