// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] array = new string[] { "1234", "1567", "-2", "computer science"};

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++) 
    {
        return;
    }
}
void Verification(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i].Length <= 3)
        {
          Console.WriteLine(arr[i]);
        }
    }

}
PrintArray(array);
Verification(array);



