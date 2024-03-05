
// 5- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

Console.WriteLine("Please enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int total = 0;

for (int i = 1; i < number; i++)   // Check the positive integer value of the number
{
    if (number % i == 0)
    {
        total = total + i;
    }
}

if (total == number)  // if total value is equal to number 
{
    Console.WriteLine(number + " is a Perfect Number");
}
else
{
    Console.WriteLine(number + " is not a Perfect Number");
}

