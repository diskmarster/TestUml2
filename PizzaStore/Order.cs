class Order
{
    private Customer _customer;
    private OrderLines _orderLines = new OrderLines();
    private List<string> _validOrderMethods = new List<string> { "EAT-IN", "TAKE-AWAY", "DELIVERY" };
    private string _defaultOrderMethod = "TAKE-AWAY";
    public string OrderMethod { get; set; }
    public int OrderId { get; }

    public Order(Customer customer, string orderMethod)
    {
        OrderId = new Random().Next(1, 99);
        _customer = customer;
        setOrderMethod(orderMethod);
        addDeliveryToOrder();
    }

    private void addDeliveryToOrder()
    {
        Product DeliveryProduct = new Product("delivery", 99, "Levering", "", 40);
        addOrderLine(DeliveryProduct);
    }

    private void setOrderMethod(string orderMethod)
    {
        if (_validOrderMethods.Contains(orderMethod))
        {
            OrderMethod = orderMethod;
        }
        else
        {
            OrderMethod = _defaultOrderMethod;
        }
    }

    public void addOrderLine(Product product)
    {
        _orderLines.AddToOrderLines(product);
    }

    public void PrintOrderLines()
    {
        _orderLines.ToString();
    }


    public float CalculateTotalPrice()
    {
        float orderSum = 0;

        foreach (var item in _orderLines.getOrderItems())
        {
            orderSum += item.Value;
        }

        return orderSum;
    }

    public string PrintOrderInformation()
    {
        return ToString();
    }

    public override string ToString()
    {
        string text = "";
        text += $"------------------------\nOrder Information\nOrder-ID: {OrderId}\nCustomer Information:\nCustomer-ID: {_customer.CustomerId}\nNavn: {_customer.Name}\nOrder Items:";

        foreach (var item in _orderLines.getOrderItems())
        {
            text += $"Produkt Navn: {item.Key}, Pris: {item.Value}\n";
        }

        text += $"\nOrder Method: {OrderMethod}\n------------------------\n";

        return text;

    }

    public void PrintOrderReceipt()
    {
        Console.Write("------------------------\n");
        Console.Write($"Kundenavn: {_customer.Name}\n\n");

        Console.Write("Bestilling:\n");

        foreach (var item in _orderLines.getOrderItems())
        {
            Console.WriteLine($"{item.Key}: {item.Value}.00 DKK");
        }

        Console.Write($"Total: {CalculateTotalPrice()}.00");
        Console.Write("\n------------------------\n");
    }



}