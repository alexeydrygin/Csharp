Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //ToLower - позволяет все символы строки перевести в нижний регистр
{
    Console.WriteLine("Ура, это же Маша!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}