
// 6 - String metotlarını araştırınız. Her bir metot için örnek yapınız.

// STRING METHODS

// 1 - Length

string name = "Fatma";
Console.WriteLine( "The length of " + name + " is: " + name.Length); // Returns the length of the value

// 2 - Contains()

Console.WriteLine(name.Contains("at"));  // If the name contains the value, it returns true
Console.WriteLine(name.Contains("AT"));  // // As you can see, it is a "case-sensitive" function

// 3 - EndsWith();

Console.WriteLine(name.EndsWith("ma")); // If the name ends with the value, it returns true
Console.WriteLine(name.EndsWith("mA")); // As you can see, it is a "case-sensitive" function

// 3 - StartsWith();

Console.WriteLine(name.StartsWith("f")); // If the name starts with the value, it returns true
Console.WriteLine(name.StartsWith("F")); // As you can see, it is a "case-sensitive" function

// 4 - Insert();

Console.WriteLine(name.Insert(name.Length, " Birel")); // You can insert the word

// 5 - Remove();

Console.WriteLine(name.Remove(0,2)); // Remove the index that you indicated

// 6 - Replace();

Console.WriteLine(name.Replace('a', '*')); // Replaces the values with the given value

// 7 - Trim ();

string trimName = " Fatma Birel Computer ";
Console.WriteLine(trimName.Trim()); // Remove the spaces both at the start and at the end.

// 8 - TrimEnd();

Console.WriteLine(trimName.TrimEnd()); // Remove the spaces at the end.

// 9 - TrimStart();

Console.WriteLine(trimName.TrimStart()); // Remove the spaces at the start.

// 10 - ToLower();

Console.WriteLine(name.ToLower()); // Make lower the string

// 10 - ToUpper();

Console.WriteLine(name.ToUpper()); // Make upper the string