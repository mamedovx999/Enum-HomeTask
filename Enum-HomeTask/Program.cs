using Application;
using Enum_HomeTask;
using Microsoft.VisualBasic;

#region Task1
IAccount account = new Account();
account.Login(new User("test@code.edu.az", "test12345", Roles.Member));
#endregion
#region Task2
static void Main(string[] args)
{
    int number = Convert.ToInt32(Console.ReadLine());
    int factorial = number.Factorial();
    Console.WriteLine($"Factorial {number} is : {factorial}");
}
#endregion
#region Task3
string word = "Salam Kamran. Necəsən Kamran";
Console.WriteLine(word.MatchCount("Kamran"));
#endregion