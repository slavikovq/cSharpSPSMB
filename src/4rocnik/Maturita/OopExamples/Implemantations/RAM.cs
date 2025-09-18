using OopExamples.Interfaces;

namespace OopExamples.Implemantations;

public class RAM : IRAM
{
    public string Name { get; set; }

    public RAM(string name)
    {
        Name = name;
    }
}