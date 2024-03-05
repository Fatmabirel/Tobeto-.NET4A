
// 7- kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.(For döngüsü kullanınız)



Console.WriteLine("Please enter the number of the students");
int studentNumber = Convert.ToInt32(Console.ReadLine());

string[] students = new string[studentNumber];  // Create an array for students's name

int[,] examScores = new int[studentNumber, 3]; // Create a 2d array for students's exam score

for (int i = 0; i < studentNumber; i++)
{
    Console.WriteLine("Please enter the name of the " + (i+1) + ".student");
    string studentName = Console.ReadLine();
    students[i] = studentName;

    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Please enter the score of exam " + (j + 1) + " for student " + students[i] + ":");
        examScores[i, j] = Convert.ToInt32(Console.ReadLine());   // Get exam score of students
    }
}

for (int i = 0; i < studentNumber; i++)
{
    int totalScore = 0;
    for (int j = 0; j < 3; j++)  // Calculate the total score
    {
        totalScore += examScores[i, j];
    }

    double averageScore = (double)totalScore / 3;  // Calculate the average

    Console.WriteLine("Student: " + students[i]);
    Console.WriteLine("Average Score: " + averageScore);
}
