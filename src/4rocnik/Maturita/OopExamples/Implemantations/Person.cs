using OopExamples.Interfaces;

namespace OopExamples.Implemantations;

public class Person : IPerson
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}