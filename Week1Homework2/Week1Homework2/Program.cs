
//2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(Input için Scanner ve döngü için for döngüsü kullanınız) 


while (true)
{
    Console.WriteLine("How many products do you want to buy?");

    string userInput = Console.ReadLine();
    int productNumber;

    double amount = 0;

    if (!int.TryParse(userInput, out productNumber))  // Prevents the string value 
    {
        Console.WriteLine("Please enter an integer value!");
        continue; // If value is not valid, go back to start
    }
    else
    {
        for (int i = 1; i <= productNumber; i++)  // Get price for all product number
        {
            Console.WriteLine("Please enter the price of " + i + ".product:");
            amount += Convert.ToDouble(Console.ReadLine());  // The prices will be added to amount 
        }
        Console.WriteLine("Total amount is: " + amount);
        break; // If value is valid, break the loop
    }
}
