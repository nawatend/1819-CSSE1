using System;
class Product
{

    private string name;
    private string type;
    private string[] ingredients;

    public Product()

    {
        Console.WriteLine("0 Para: Empty Product");
    }
    public Product(string name)

    {
        this.name = name;

        Console.WriteLine("1 Para. " + name);
    }
    public Product(string name, string type, string[] ingredients)

    {
        this.name = name;
        this.type = type;
        this.ingredients = ingredients;

        Console.WriteLine("3 Para. " + name + " " + type + " ingredients[0]: " + ingredients[0]);
    }


}