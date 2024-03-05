static void WarningMessages()  // Create a function that converts warning message
{
    Console.WriteLine("Please enter a valid order number between 1-5!");
}

while (true) // if user enters correct value
{
    WarningMessages(); 

    string userInput = Console.ReadLine(); // user enters the value
    int orderNumber;

    if (!int.TryParse(userInput, out orderNumber) || orderNumber < 1 || orderNumber > 5) // if the value is not between 1 and 5 AND the value is not integer
    {
        continue; // invalid value, go back to start
    }
    else
    {
        switch (orderNumber) // switch for order number
        {
            case 1:
                Console.WriteLine("Pen was ordered");
                break;
            case 2:
                Console.WriteLine("Wallet was ordered");
                break;
            case 3:
                Console.WriteLine("Toy was ordered");
                break;
            case 4:
                Console.WriteLine("Book was ordered");
                break;
            case 5:
                Console.WriteLine("Candle was ordered");
                break;
            default:
                Console.WriteLine("Invalid order number");
                break;
        }
        break; // if the order number is correct, break the loop
    }
}
