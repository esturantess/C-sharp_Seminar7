Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// Array.ConvertAll приводит все элементы к указанному типу (нужно указать метод конвертации)
// int.Parse - тип конвертации; в примере выше из stroke переведет в int.
// .Split() разбивает строку на отдельные элементы; например, вместо "12345"-> "1","2","3","4","5" (массив из строк)

// var arr2 = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
System.Console.WriteLine("Количество элементов больше 0: " + count);

// Задача на пересечение прямых

// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());


// var x = -(b1 - b2) / (k1 - k2);
// var y = k1 * x + b1;

// x = Math.Round(x, 3);
// y = Math.Round(y, 3);

// Console.WriteLine($"Пересечение в точке: ({x};{y})");

// var - неявный тип данных; тип данных подберется автоматически.
// Например:
// var k1 = Convert.ToDouble(Console.ReadLine()); - k1 получит тип double
// var rand = new Random(); - rand получит тип Random
// var testArray = new int [2,2]; - testArray получит тип int [,]

// var нельзя использовать в качестве типа функции или её аргумента.
// Можно использовать только для переменных.
