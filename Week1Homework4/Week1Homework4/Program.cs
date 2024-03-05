
// 4- Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız.(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)


Random random = new Random();

int guessNumber = random.Next(1, 10);
//Console.WriteLine(guessNumber);

Console.WriteLine("Can you guess the number? Please enter the number between 1 and 10");

int userNumber = Convert.ToInt32(Console.ReadLine());

while(userNumber != guessNumber) // if user number is not equal to guessNumber
{
    if(userNumber > guessNumber) // if user number is bigger than guessNumber
    {
        Console.WriteLine("Please enter smaller number");
        userNumber = Convert.ToInt32(Console.ReadLine()); //guess again
    }
    else
    {
        Console.WriteLine("Please enter bigger number"); // if user number is smaller than guessNumber
        userNumber = Convert.ToInt32(Console.ReadLine()); //guess again
    }

}

Console.WriteLine("Congratulations! You guessed correctly. The number was: " + guessNumber);
