
void FillArray(string[] arrA, string[] arrB)
{
    for(int i = 0; i < arrA.Length; i ++)
    {
        Console.WriteLine("Введите элемент массива: ");
        arrA[i] = Console.ReadLine();
        arrB[i] = "";
    }
}


int Sieve(string[] arrA, string[] arrB, int k=0)
{
    for(int i = 0; i < arrA.Length; i ++)
    {
        if(arrA[i].Length <= 3)
        {
            arrB[k] = arrA[i];
            k++;
        }
    }
    return k;
}


void FillResult(string[] arrB, string[] arrR, int k)
{
    for(int i = 0; i < k; i ++)
        arrR[i] = arrB[i];
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
int counter = 0; // количество элементов массива B нужной длины

FillArray(A, B);
counter = Sieve(A, B, counter);
string[] Result = new string[counter]; // 
FillResult(B, Result, counter);

PrintArray(Result);