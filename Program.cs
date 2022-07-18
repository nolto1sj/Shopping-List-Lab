Dictionary<string, decimal> items = new Dictionary<string, decimal>()
{
    { "car", 20000.99m },
    { "sandwich", 5.99m },
    { "notepad", 2.69m },
    { "baseball bat", 45.79m },
    { "Playstation 5", 499.99m },
    { "sunflower", 3.50m },
    { "fiji water", 5.15m },
    { "banana", 0.59m }
}; //dictionary of items

bool CheckList(string a)
{
    if (items.ContainsKey(a))
    {
        return true;
    }
    else
    {
        return false;
    }
} //method for if item exists


List<string> shoppingList = new List<string>(); //list of items ordered

bool loop = true;

Console.WriteLine("Welcome to The Stuff Store!" + "\n");

while (loop)
{

    Console.WriteLine("Item  Price" + "\n");
    Console.WriteLine("=======================");
    foreach (var item in items) //listing the items
    {
        Console.WriteLine(item);
    }

    Console.Write("\nWhat item would you like to order? ");
    string input = Console.ReadLine(); //user input1
    if (CheckList(input))
    {
        Console.WriteLine($"\nAdding {input} to the cart for {items[input]}. \n");
        shoppingList.Add(input);

        Console.Write($"\nWould you like to order anything else (y/n)?: ");
        string input2 = (Console.ReadLine().ToLower());
        if (input2 == "y")
        {
            Thread.Sleep(500);
            Console.Clear();
        }
        else if (input == "n")
        {
            loop = false;
        }
        else
        {
            loop = false;
        }
    }
    else
    {
        Console.WriteLine($"\nSorry, we don't have those. Please try again. \n");
        Thread.Sleep(1500);
        Console.Clear();
    }
}

Console.WriteLine("\nThanks for your order!");
Console.WriteLine("Here's what you got: \n");

decimal GetValue(string a)
{
    return items[a];
}

decimal total = 0;
decimal average = 0;

for (int i = 0; i < shoppingList.Count(); i++) //displays list of items ordered
{
    Console.WriteLine($"{shoppingList[i]} for {GetValue(shoppingList[i])}");
    total += GetValue(shoppingList[i]);
}

average = total / shoppingList.Count;
Console.WriteLine($"\nYour total is {total}. The average price for all items ordered: {Math.Round(average, 2)} ");