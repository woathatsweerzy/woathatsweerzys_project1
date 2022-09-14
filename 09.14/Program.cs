int sugarAmount = Convert.ToInt32(Console.ReadLine());

/*for (int i = 0; i <= sugarAmount; i++)
{
    Console.WriteLine("В чае уже " + i + "Ложка сахара");
}

Console.ReadLine();*/
int i = 1;
while (i <= sugarAmount)
{
    Console.WriteLine("В чае уже " + i + "Ложка сахара");
    i++;
}
Console.WriteLine(i);