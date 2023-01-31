using BuilderPattern.Implement;
using BuilderPattern.Views;

internal class Program
{
    private static void Main(string[] args)
    {
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Builder = builder;

        Console.WriteLine("Standard basic product:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Standard full featured product:");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        // Remember, the Builder pattern can be used without a Director
        // class.
        Console.WriteLine("Custom product:");
        builder.BuildPartA();
        builder.BuildPartC();
        Console.Write(builder.GetProduct().ListParts());
    }
}