
public class Pizza
{
    public string Type { get; set; }
    public int Number { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Id { get; set; }
    public string Topping { get; set; }

    public Pizza(string itemType, int itemNumber, string itemName, string itemDescription, double itemPrice)
    {
        Id          = 0;
        Type        = itemType;
        Number      = itemNumber;
        Name        = itemName;
        Description = itemDescription;
        Price       = itemPrice;
    }

    public override string ToString()
    {
        return $"";
    }
}
