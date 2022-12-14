Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "владислав")
{
	Console.WriteLine("Ура! это Влад зашёл!!!");
}
else
{
	Console.WriteLine("Фу, это не Влад!:(");
	Console.Write("Ну, привет, ");
	Console.WriteLine(username);
}