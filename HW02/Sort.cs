using System;

class Sort
{
    static void Main(string[] args)
    {
        int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        Console.WriteLine("Выберите тип сортировки (1 - сортировка пузырьком, 2 - сортировка вставками): ");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        Console.WriteLine();

        if (choice == 1)
        {
            BubbleSort(array);
        }
        else if (choice == 2)
        {
            InsertionSort(array);
        }
        else
        {
            Console.WriteLine("Некорректный выбор сортировки.");
            return;
        }
        Console.Write("Отсортированный массив:");
        Console.WriteLine();
        PrintArray(array);
        
    }

    static void BubbleSort(int[,] array) // Сортировка пузырьком
    {
        int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols - 1; j++)
        {
            for (int k = 0; k < cols - j - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k]; // Обмен элементы
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }

    }

    static void InsertionSort(int[,] array) // Сортировка вставками
    {
        int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 1; j < cols; j++)
        {
            int key = array[i, j];
            int k = j - 1;

            while (k >= 0 && array[i, k] > key) // Перемещение элементов массива
            {                                   // Которые больше, чем key
                array[i, k + 1] = array[i, k];  // на одну позицию вперед
                k--;
            }
            array[i, k + 1] = key;
        }
    }
    }

    static void PrintArray(int[,] array) // Вывод массива на экран
    {
        int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); // Переход на строку вниз, после каждой строки массива
    }
    
    }
}
