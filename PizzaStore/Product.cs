
class Product
{
    public string Type { get; set; }
    public int Number { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public int InternalProductId { get; set; }

    public Product(string itemType, int itemNumber, string itemName, string itemDescription, float itemPrice)
    {
        InternalProductId = new Random().Next(1, 99);
        Type        = itemType;
        Number      = itemNumber;
        Name        = itemName;
        Description = itemDescription;
        Price       = itemPrice;
    }
    
    public override string ToString()
    {
        return $"Produkt Information \n\n" +
            $"Product-ID: {InternalProductId} \n" +
            $"Type: {Type} \n" +
            $"Nummer: {Number} \n" +
            $"Navn: {Name} \n" +
            $"Ingredienser: {Description}\n" +
            $"Pris: {Price} \n";

    }
     

}