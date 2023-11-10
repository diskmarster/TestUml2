class Store
{
    public void Start()
    {
        // Pizza Objects
        Product Pizza1 = new Product("pizza", 1, "Margherita", "Tomat og ost",                    69);
        Product Pizza2 = new Product("pizza", 2, "Vesuvio", "Tomat, ost og skinke",               75);
        Product Pizza3 = new Product("pizza", 3, "Capricciosa", "Tomat, ost, skinke og svampe",   80);

        // Customer Objects
        Customer Customer1 = new Customer("Ivan");
        Customer Customer2 = new Customer("Per");
        Customer Customer3 = new Customer("Nilma");

        // Order 1 to Customer 1
        Order Order1 = new Order(Customer1, "DELIVERY");
        Order1.addOrderLine(Pizza1);

        // Order 2 to Customer 2
        Order Order2 = new Order(Customer2, "DELIVERY");
        Order2.addOrderLine(Pizza2);

        // Order 3 to Customer 3
        Order Order3 = new Order(Customer3, "DELIVERY");
        Order3.addOrderLine(Pizza3);

        // Order Information
        Console.WriteLine(Order1.PrintOrderInformation());
        Console.Write("\n");
        Console.WriteLine(Order2.PrintOrderInformation());
        Console.Write("\n");
        Console.WriteLine(Order3.PrintOrderInformation());
        Console.Write("\n");

        // Order Receipt
        Order1.PrintOrderReceipt();
        Order2.PrintOrderReceipt();
        Order3.PrintOrderReceipt();
    
    }
}