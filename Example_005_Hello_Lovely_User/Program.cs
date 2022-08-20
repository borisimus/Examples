Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.Write("УАу, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}