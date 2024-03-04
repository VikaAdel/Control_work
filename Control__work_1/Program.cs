
        // Запрос у пользователя ввода элементов массива
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine().Split();

        //Создание нового массива
        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Результат:");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write(resultArray[i] + " ");
        }

        //Console.ReadLine(); // Чтобы консольное окно не закрылось сразу
    

    //Определение метода для формирования нового массива
    static string[] FilterArray(string[] inputArray)
    {
        //Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        //Создание нового массива с учетом подсчитанного количества строк
        string[] resultArray = new string[count];
        int index = 0;

        //Заполнение нового массива строками, удовлетворяющими условию
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }


        return resultArray;
    }
