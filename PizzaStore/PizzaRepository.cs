
public class PizzaRepository
{
    private Dictionary<int, Pizza> _pizzas;

    public PizzaRepository()
    {
        _pizzas = new Dictionary<int, Pizza>();
    }

    public void Create(Pizza pizza)
    {
        pizza.Id = NextId();
        _pizzas.Add(pizza.Id, pizza);
    }

    public Pizza? Read(int id)
    {
        return _pizzas.ContainsKey(id) ? _pizzas[id] : null;
    }

    public void Update(int id, Pizza pizza)
    {
        Pizza? existingPizza = Read(id);

        if (existingPizza != null)
        {
            existingPizza.Number            = pizza.Number;
            existingPizza.Name              = pizza.Name;
            existingPizza.Description       = pizza.Description;
            existingPizza.Price             = pizza.Price;         

        }
    }

    public void Delete(int id)
    {
        _pizzas.Remove(id);
    }

    public List<Pizza> Search(int pizzaId)
    {
        List<Pizza> searchResult = new List<Pizza>();

        foreach (Pizza pizza in _pizzas.Values)
        {
            if (pizza.Id == pizzaId)
            {
                searchResult.Add(pizza);
            }
        }

        return searchResult;
    }

    public void PrintMenu()
    {
        Console.WriteLine();
        Console.WriteLine($"--- All Pizzas ({_pizzas.Count} in total) ---");

        foreach (Pizza pizza in _pizzas.Values)
        {

            Console.WriteLine($"ID: {pizza.Id} | {pizza.Number} - {pizza.Name} - {pizza.Description} - {pizza.Topping} - {pizza.Price} DKK");
        }

        Console.WriteLine();
    }

    private int NextId()
    {
        int maxId = 0;

        foreach (int id in _pizzas.Keys)
        {
            if (id > maxId)
            {
                maxId = id;
            }
        }

        return maxId + 1; ;
    }
}
