class Customer
{
    public User User { get; set; }
    public string Name { get; set; }
    public int CustomerId { get; }

    public Customer(string name)
    {
        CustomerId = new Random().Next(1, 100);
        Name = name;      
    }

    public override string ToString()
    {
        return $"Customer name is {Name} and has Id {CustomerId}"; 
    }

}