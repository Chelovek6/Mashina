using Mashina;

Car[] array = new Car[0];
int n = 0;
bool a = true;
while (a)
{
    Console.WriteLine("\n Меню: \n 1 - Добавить машину \n 2 - Поиск по базе \n 3 - Показать все машины в базе \n 4 - Колличество машин на стоянке \n 5 - Выход из программы");
    ConsoleKey key = Console.ReadKey().Key;
    Console.WriteLine();
    switch (key)
    {
        case ConsoleKey.D1:
            Komandei.AddCar(ref array, n);
            n++;
            break;
        case ConsoleKey.D2:
            Car.SearchCar(ref array);
            break;
        case ConsoleKey.D3:
            Komandei.PrintInfo(ref array);
            break;
        case ConsoleKey.D4:
            Console.WriteLine("Машин на стоянке:");
            Car.SearchCarInfo(ref array);
            break;
        
        case ConsoleKey.D5:
            Console.WriteLine("Выход из программы");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Вы ввели неверную клавишу");
            break;
    }
}