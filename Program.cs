void Zadacha50()
{
    Random random = new Random();
    int rows = random.Next(2,7);
    int columns = random.Next(4,10);
    int [,] array = new int [rows, columns];
    FillArray(array);
    PrintArray(array);

    Console.WriteLine("Введите строку элемента");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец элемента");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row >= 1 && row <= rows && column >=1 && column <= columns)
    {
        Console.WriteLine($"Заданный элемент = [{row}, {column}] = {array [row - 1, column - 1]}");

    }
    else
    {
        Console.WriteLine("Такого элеманта нет");
    }
    void FillArray(int[,] array)
    {
        Random random = new Random(); 
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            array[i, j] = random.Next(0,100);
            }
        }
    }
    void PrintArray(int[,] array)
    {
        Console.WriteLine();
        Console.WriteLine("Вывод массива");
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i< rows; i++)
        {
            for (int j = 0; j < columns; j++ )
                Console.Write(array [i, j] + "\t");
                Console.WriteLine();
        }
    }
}
Zadacha50();
