
// 3 - Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

// While Loop

/*
Console.WriteLine("Please enter a number. I can create tree for you :)");  // Get number value

int number = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine(number);

while(number > 0) // as long as number value is greater than 0, while loop will be active
{
    for(int i = number; i > 0; i--)
    {
        Console.Write("*");  // * will be added to the tree
    }

    Console.WriteLine(" ");
    number--; // increase the number, otherwise the loop will be infinite!!
}
Console.WriteLine("The tree was created! Have fun!");
*/



// Do-While Loop

Console.WriteLine("Please enter a number");  // Get number value

int numberValue = Convert.ToInt16(Console.ReadLine());


do // first do these conditions
{
    Console.WriteLine(numberValue);
    numberValue++;

} while (numberValue < 100);

Console.ReadLine();

