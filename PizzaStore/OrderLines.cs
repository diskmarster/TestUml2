
class OrderLines
{

    public Dictionary<string, float> OrderItems = new Dictionary<string, float>();
    public void AddToOrderLines(Product product)
    {
        OrderItems.Add(product.Name, product.Price);
    }

    public Dictionary<string, float> getOrderItems()
    {
        return OrderItems;
    }

    public override string ToString()
    {
        string text = "";

        text = "Order Line Information:\n";

        foreach (var item in OrderItems)
        {
            text += $"Produkt Navn: {item.Key}, Pris: {item.Value}";
        }

        return text;

    }

}