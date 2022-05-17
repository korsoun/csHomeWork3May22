// Задача 21
// Принять координаты двух точек и найти расстояние между ними в трехмерном пространстве

Console.WriteLine("Введите последовательно кооординаты двух точек.");

Console.WriteLine("Точки A: ");                              // получение координат точек
double coordXA = Convert.ToDouble(Console.ReadLine());       // 
double coordYA = Convert.ToDouble(Console.ReadLine());       //
double coordZA = Convert.ToDouble(Console.ReadLine());       //  
Console.WriteLine("Точки B: ");                              //
double coordXB = Convert.ToDouble(Console.ReadLine());       //
double coordYB = Convert.ToDouble(Console.ReadLine());       //
double coordZB = Convert.ToDouble(Console.ReadLine());       //


string GetDistanceIn3D(double coordXA, double coordXB, double coordYA, double coordYB, double coordZA, double coordZB)  // объявление метода
{
Console.Write("Ваши точки: A (" + coordXA + "; " + coordYA + "; " + coordZA + "), B (");   //
Console.WriteLine(coordXB + "; " + coordYB + "; " + coordZB + ").");                           //    представление точек в красивом виде

double dist = Math.Sqrt(Math.Pow(coordXB - coordXA, 2) + Math.Pow(coordYB - coordYA, 2) + Math.Pow(coordZB - coordZA, 2)); // нахождение расстояния в типе double
string result = string.Format("{0:f2}", dist);                // представление расстояния в типе string  с точностью до двух знаков после запятой
return result;
}


string distIn3D = GetDistanceIn3D(coordXA, coordXB, coordYA, coordYB, coordZA, coordZB);  //   вывод расстояния 
Console.Write("Расстояние между этими точками равно ");                                   //
Console.Write(distIn3D);                                                                  //  





