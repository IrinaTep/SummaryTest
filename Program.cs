void FillArray(string[] arrA, string[] arrB)
{
    for(int i = 0; i < arrA.Length; i ++)
    {
        Console.WriteLine("Введите элемент массива: ");
        arrA[i] = Console.ReadLine();
        arrB[i] = "";
    }
}


void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


Console.Write("Введите длину исходного массива: ");
int aLength = Convert.ToInt32(Console.ReadLine());
string[] A = new string[aLength]; // исходный массив, заполняемый пользователем
string[] B = new string[aLength]; // промежуточный массив с элементами длиной меньше 3

FillArray(A, B);

PrintArray(A);