**Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

**Решение: **

1. * Запрашиваем данные у пользователя:
 Программа начинается с запроса у пользователя ввести элементы массива через пробел.
2. * Создание нового массива: После получения ввода формируется новый массив строк с использованием метода FilterArray.
3. Вывод результата: Программа выводит результат в консоль, перебирая элементы нового массива.
4. Метод FilterArray: Этот метод подсчитывает количество строк, удовлетворяющих условию (длина меньше или равна 3) в исходном массиве и создает новый массив, заполняя его соответствующими строками.
5. Вывод результата: Новый массив выводится в консоль для пользователя.