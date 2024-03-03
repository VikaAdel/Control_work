
        // Запрашиваем у пользователя ввод элементов массива
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine().Split();

        // Создаем новый массив строк
        string[] resultArray = FilterArray(inputArray);

        // Выводим результат
        Console.WriteLine("Результат: ");
        foreach (string item in resultArray)
        {
            Console.Write(item + " ");
        }

        // Console.ReadLine(); // Пауза для просмотра результата, добавила для себя.
   

    //Определяем метод для формирования нового массива
    static string[] FilterArray(string[] inputArray)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив с учетом подсчитанного количества строк
        string[] resultArray = new string[count];
        int index = 0;

        //Заполняем новый массив строками, удовлетворяющие наши условия
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultArray[index] = item;
                index++;
            }
        }

        //Возвращаем результат массива
        return resultArray;
    }

