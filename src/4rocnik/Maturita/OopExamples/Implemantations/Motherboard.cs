using OopExamples.Interfaces;

namespace OopExamples.Implemantations;

public class Motherboard : IMotherBoard
{
    public string Name { get; set; }

    public Motherboard(string name)
    {
        Name = name;
    }
}