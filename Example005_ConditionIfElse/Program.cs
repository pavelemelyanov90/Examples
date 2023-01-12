Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "михалыч")  
{
     Console.WriteLine("Пошёл ты на х*р, козёл");
}
else
{
     Console.Write("Привет, ");
     Console.WriteLine(username);
}