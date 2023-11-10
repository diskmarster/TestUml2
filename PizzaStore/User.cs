
class User
{
    public int UserId { get; set; }
    public string Type { get; set; }
    public string Role { get; set; }
    public string Name { get; set; }

    // type = customer, employee.
    // role = user, admin, staff etc.
    public User(string type, string role, string name)
    {
        UserId  = new Random().Next(1,99);
        Type    = type;
        Role    = role;
        Name    = name;
    }

    public override string ToString()
    {
        return $"User-ID: {UserId}\n" +
            $"Navn: {Name}\n" +
            $"Type: {Type}\n" +
            $"Role: {Role}";
    }
}