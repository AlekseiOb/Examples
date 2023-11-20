Console.Write("Enter the username: ");
string? username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}