using System;
public class Cat
{
    public Cat(int age, string nome)
    {
        Age = age;
        Nome = nome;
    }
    public int Age { get ; set; }
    public string Nome { get; set; }
    public void Mia()
    {
        Console.WriteLine($"{Nome} says: Meow.");
    }
}

