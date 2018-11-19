using System;


class MenuItem
{

    private Product product = new Product();
    private Price price = new Price();


    public MenuItem()
    {
        Console.WriteLine("0 Para: Empty MenuItem");
    }
    public MenuItem(Product product)
    {
        this.product = product;

        Console.WriteLine("1 Para. " + product);

    }
    public MenuItem(Product product, Price price)
    {
        this.product = product;
        this.price = price;

        Console.WriteLine("2 Para. " + product + " " + price);
    }


    public override string ToString()
    {
        return product.ToString() + ": " + price.ToString();
    }
}