using System.Text.RegularExpressions;
using OopExamples.Interfaces;

namespace OopExamples.Implemantations;

public class Computer : IComputer
{
    public IEntity Owner { get; set; }
    public IMotherBoard MotherBoard { get; init; }
    public ICPU Cpu { get; init; }
    public IGPU Gpu { get; init; }
    public IRAM Ram { get; init; }
    public IPowerSupply PowerSupply { get; init; }
    public ICase Case { get; init; }
    public IMonitor[] Monitors { get; init; }
    public bool IsOn { get; set; }
    public bool IsPersonalPC { get; set; }
    public bool IsCompanyPC { get; set; }

    public void PowerUp()
    {
        IsOn = true;
    }

    public void ShutDown()
    {
        IsOn = false;
        /*aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa*/
    }

    public void PressPowerButton()
    {
        IsOn = !IsOn;
    }

    public void Print(string text)
    {
        Console.WriteLine($"[PRINT] {text}");
    }


    public float Compute(string equation)
    {
        equation.Replace(".", ",");
            
        string[] splitProblem = Regex.Split(equation, @"\s+");
        double finished = 0;
            
        double firstNumber = Double.Parse(splitProblem[0].Replace(".", ","));
        double secondNumber = Double.Parse(splitProblem[2].Replace(".", ","));

        if (secondNumber == 0)
        {
            return 0;
        }
            
        switch (splitProblem[1])
        {
            case "+":
                finished = firstNumber +  secondNumber; 
                break;
            case "-":
                finished = firstNumber - secondNumber;
                break;
            case "*":
                finished = firstNumber *secondNumber;
                break;
            case "/":
                finished = firstNumber / secondNumber;
                break;
            case "**":
                finished = Math.Pow(firstNumber, secondNumber);
                break;
            default: 
                Console.WriteLine("Wrong user input!");
                break;
        }

        return (float)finished;
    }

    public void ChangeOwner(IEntity? newOwner)
    {
        if (newOwner == null)
        {
            RemoveOwner();
            return;
        }

        if (newOwner is Person person)
        {
            Owner = person;
            IsPersonalPC = true;
            IsCompanyPC = false;
        }
        else if (newOwner is Company company)
        {
            Owner = company;
            IsPersonalPC = false;
            IsCompanyPC = true;
        }
    }


    public void RemoveOwner()
    {
        Owner = null;
        IsPersonalPC = false;
        IsCompanyPC = false;
        
        
    }

    public IComputer BuildNewComputer(IComputerConfiguration configuration)
    {
        return new Computer
        {
            MotherBoard = configuration.MotherBoard,
            Cpu = configuration.Cpu,
            Gpu = configuration.Gpu,
            Ram = configuration.Ram,
            PowerSupply = configuration.PowerSupply,
            Case = configuration.Case,
        };
    }

}