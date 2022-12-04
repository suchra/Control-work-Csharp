////Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.
//При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[] array1 = new string[5] {"hello", "wow", "yes", "B747", "B777"};
string[] array2 = new string[array1.Length];

void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void Printarray(string[] array)
{
    {
        Console.WriteLine($"[{string.Join(", ", array1)}] -> [{string.Join(", ", array2)}]");
    }
    Console.WriteLine();
}

NewArray(array1, array2);
Printarray(array2);