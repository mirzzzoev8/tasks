namespace Task4;
public class Product
{
    string Name ;
    double Price ;
    int Quantity ;

    public Product(string _name, double _price, int _quantity)
    {
        Name = _name;
        Price = _price;
        Quantity = _quantity;
    }

    public void PrintProduct()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Quantity: {Quantity}");
    }
}
