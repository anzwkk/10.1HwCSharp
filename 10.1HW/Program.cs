Console.WriteLine("Введіть ім’я та прізвище: ");
string input = Console.ReadLine();

string[] parts = input.Split(' ');
string firstName = parts[0];
string lastName = parts[1];

if (firstName[0] == lastName[0])
{
    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
}
else
{
    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
}