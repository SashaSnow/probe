Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username. ToLower() == "женя")
{
    Console.WriteLine("Ура, это же ЖЕНЯ!");
}
else
{
    Console.Write("Привет Землянин!, ");
    Console.WriteLine(username);
}