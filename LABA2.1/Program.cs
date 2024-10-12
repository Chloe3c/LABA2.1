try
{
    Console.WriteLine("Введите x ");
    bool x = bool.Parse(Console.ReadLine()) ;
    Console.WriteLine("Введите y ");
    bool y = bool.Parse(Console.ReadLine());
    Console.WriteLine("Введите z ");
    bool z = bool.Parse(Console.ReadLine());
    bool result = x ^ (!(!y || z)) || y;
    Console.WriteLine($"{result}");
}
catch
{
    Console.WriteLine("Введите верно!");
}