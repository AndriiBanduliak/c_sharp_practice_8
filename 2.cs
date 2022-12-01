
using static System.Console;
Clear();


WriteLine("Enter collums: ");
int c = Int32.Parse(ReadLine());

WriteLine("Enter rows: ");
int r = Int32.Parse(ReadLine());


int[,] arr = GetMatrixArray(r, c, 10, 89);

if (arr.GetLength(0) != arr.GetLength(1))
{
    WriteLine("It's a boolshit"); return;
}

PrintMatrixArray(arr);

arr = arrSwap(arr);

WriteLine();
PrintMatrixArray(arr);

int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();

    }
}

int[,] arrSwap(int[,] arr)
{
    int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[j, i] = arr[i, j];
        }
    }
    return result;
}

