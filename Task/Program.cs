// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Зададим явно первоначальный массив строк:
string[] initialArray = { "12345", "1", "1234", "123", "12", "12345678", "-0", "-:)" };

// Массив результатов объявим пустым:
string[] resultArray = { };

// Счетчик удовлетворяющих условию строк из первоначального массива:
int resultArrayIndex = 0;

// Цикл по первоначальному массиву:
foreach (string str in initialArray)
{
    if (str.Length <= 3)
    {
        // Увеличиваем размер результирующего массива на 1
        // и записываем в него удовлетворяющую условию строку из первоначального массива:
        Array.Resize(ref resultArray, resultArrayIndex + 1);

        resultArray[resultArrayIndex] = str;

        resultArrayIndex++;
    }
}

// Данная функция выводит в консоль элементы массива, передаваемого в качестве параметра:
static void WriteArrayToConsole(string[] array)
{
    int arrayLength = array.Length;

    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"{array[i]}");

        if (i < arrayLength - 1)
        {
            Console.Write(", ");
        }
    }
}

// Выводим в консоль первоначальный и результирующий массивы:

// Первоначальный:
Console.Write("[ ");
WriteArrayToConsole(initialArray);
Console.Write(" ] => ");

// Результирующий:
Console.Write("[ ");
WriteArrayToConsole(resultArray);
Console.Write(" ]");
