// Задача 23
// Принять на вход число N и вывести таблицу кубов чисел от 1 до N

Console.WriteLine("Введите натуралное число.");
int number = Convert.ToInt32(Console.ReadLine());

void GetCubeTable(int N)                                          // объявление метода
{
    int i;
    Console.WriteLine("_______________________");                      // верхняя граница таблицы
    Console.WriteLine("|{0,10}|{1,10}|", "Число", "Куб");              // шапка таблицы
    for(i = 1; i <= N; i++)                                       // получение строк с числом и его кубом 
    {                                                                  // 
        Console.WriteLine("|{0,10}|{1,10}|", i, Math.Pow(i, 3));       //
    }                                                                  // 
    Console.WriteLine("-----------------------");                      // нижня граница таблицы 

}

GetCubeTable(number);                                                  // вызов метода

