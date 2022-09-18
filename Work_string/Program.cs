// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввсести с клавиатуры, либо задать а старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
//["hello", "2", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

class Program
{
    static void Main (string []args)
    {
        string[]work;
        
        Console.WriteLine("Введите слова, символы, числа(через пробел):");
        string array = Console.ReadLine();
        work = array.Split(' ');
        var result = new string [work.Length];
        var newSize = 0;
        var go = work;
        foreach (var item in work)
        {
            if (item.Length <=3)
            {
                result[newSize] = item;
                newSize++;
            }
        }   
            Console.Write(string.Join('\n', result, 0, newSize ));
          Console.ReadKey();

        
    }
}

