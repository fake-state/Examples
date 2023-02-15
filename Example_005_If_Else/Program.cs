Console.Write("Введите Ваше имя: ");
string? username = Console.ReadLine();
if (username?.ToLower() == "алена")
{
  Console.WriteLine("Ура, это же Алена!");
}
else
{
  Console.Write("Привет," + " " + username);
}