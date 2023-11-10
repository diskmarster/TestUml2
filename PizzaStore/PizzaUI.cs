
public class PizzaUI
{
    private PizzaRepository _pizzaRepo;

    public PizzaUI()
    {
        _pizzaRepo = new PizzaRepository();
    }

    public void RunUI()
    {
        Console.WriteLine("Available Options:");
        Console.WriteLine("1: Create Pizza");
        Console.WriteLine("2: Delete Pizza");
        Console.WriteLine("3: Update Pizza");
        Console.WriteLine("4: Find Pizza");
        Console.WriteLine("5: Show Menu");
        Console.WriteLine("9: Exit Program");
        Console.WriteLine();

        int choice = 0;

        while (choice != 9)
        {
            choice = UserInputReader.ReadIntFromUser("Enter choice");

            if (choice == 9)
                continue;

            if (choice == 1)
                Create();

            if (choice == 2)
                Delete();

            if (choice == 3)
                Update();

            if (choice == 4)
                Read();

            if (choice == 5)
                ShowAll();
        }

        Console.WriteLine("Quitting...");
    }

    private void Create()
    {
        Console.WriteLine("Creating Pizza...");

        _pizzaRepo.Create(CreateNewPizza());

        Console.WriteLine("Pizza created...");
    }

    private void Read()
    {
        Console.WriteLine("Reading pizza...");

        int id = UserInputReader.ReadIntFromUser("Enter pizza id ");

        Pizza? pizza = _pizzaRepo.Read(id);

        if (pizza != null)
            Console.WriteLine($"Pizza Found! ID: {pizza.Id} | {pizza.Number} - {pizza.Name} - {pizza.Description} - {pizza.Topping} - {pizza.Price} DKK");
        else
            Console.WriteLine($"No pizza with id {id} found");
    }

    private void Update()
    {
        Console.WriteLine("Updating pizza...");

        int id = UserInputReader.ReadIntFromUser("Enter pizza id ");

        Pizza? pizza = _pizzaRepo.Read(id);

        if (pizza != null)
        {
            _pizzaRepo.Update(id, CreateNewPizza());
            Console.WriteLine("Pizza updated");
        }
        else
            Console.WriteLine($"No pizza with id {id} found");
    }

    private void Delete()
    {
        Console.WriteLine("Deleting pizza...");

        int id = UserInputReader.ReadIntFromUser("Enter pizza id ");

        Pizza? pizza = _pizzaRepo.Read(id);

        if (pizza != null)
        {
            _pizzaRepo.Delete(id);
            Console.WriteLine("Pizza deleted");
        }
        else
            Console.WriteLine($"No pizza with id {id} found");


    }

    private void ShowAll()
    {
        _pizzaRepo.PrintMenu();
    }

    private Pizza CreateNewPizza()
    {
        int itemNumber = UserInputReader.ReadIntFromUser("Enter pizza number");
        string itemName = UserInputReader.ReadStringFromUser("Enter pizza name");
        string itemDescription = UserInputReader.ReadStringFromUser("Enter pizza description");
        double itemPrice = UserInputReader.ReadDoubleFromUser("Enter pizza price as xx.xx");


        return new Pizza("pizza", itemNumber, itemName, itemDescription, itemPrice);
    }
}
