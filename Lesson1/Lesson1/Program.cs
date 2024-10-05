 try
 {
     Console.WriteLine("Введите x:");
     double x = double.Parse(Console.ReadLine());
     Console.WriteLine("Введите y:");
     double y = double.Parse(Console.ReadLine());
     double F = Math.Sqrt((2 + y) * (2 + y) + Math.Pow(7, Math.Sqrt(Math.Sin(y + 5)))) / Math.Log((x + 1)) - Math.Pow(3,y);
     Console.WriteLine($"F={F:F2}");
 }
 catch
 {
     Console.WriteLine("Введите правильное значение!");
 }     