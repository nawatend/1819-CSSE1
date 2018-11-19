using System;
class Price
{

    private string currency;
    private double price;




    public Price()
    {

        Console.WriteLine("0 Para.  EMPTY PRICE");
    }
    public Price(double price)
    {

        this.price = price;
        Console.WriteLine("0 Para. " + price);
    }
    public Price(string currency, double price)
    {
        this.currency = currency;
        this.price = price;
        Console.WriteLine("2 Para. " + currency + " " + price);
    }


    public override string ToString()
    {
        return this.currency + " " + this.price;
    }
}