// Задача 19
// Принять пятизначное число и проверить, яляется ли оно палиндромом

string PalindromeCheck(int number)                                                            // объявление метода PalindromeCheck
{
    string checkResult = "0";
    if (number / 10000 == number % 10 && (number % 10000) / 1000 == (number % 100) / 10)
    {
        checkResult = "Число палиндром.";
    }
    else
    {
        checkResult = "Число не палиндром.";
    }
    return checkResult;
}

Console.WriteLine("Введите пятизначное число.");                                              // вывод приглашения ко вводу   
int number = Convert.ToInt32(Console.ReadLine());                                             // чтение проверяемого числа

Console.WriteLine(PalindromeCheck(number));                                                   // вывод результата проверки в методе PalindromeCheck
