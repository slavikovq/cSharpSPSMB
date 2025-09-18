using OopExamples.Interfaces;

namespace OopExamples.Implemantations;

public class PowerSupply : IPowerSupply
{
    public string Name { get; set; }

    public PowerSupply(string name)
    {
        Name = name;
    }
}