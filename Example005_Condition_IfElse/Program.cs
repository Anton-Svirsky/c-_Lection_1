Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "нася")
{
    Console.WriteLine("Ура, это же Нася!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}