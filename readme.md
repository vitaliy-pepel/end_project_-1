# Итоговый проект 1 четверти
> автор: Виталий Евгеньевич Ч.

Задачи:
1. Создать репозиторий GitHub;
2. Нарисовать блок-схему алгоритма;
3. Снабдить работу описанием решения (+ контроль версий);
4. Написать программу.

## Блок-схема проекта
![блок-схема](diagram.png)

## Описание решения
*По условию:* Дан массив строк.
1. Заведём пустой массив для записи результата.
2. Для перебора элементов массива воспользуемся циклом с заданными числом повторений:
перебор по индексам начаная с нулевого до длины массива.
Если длина элемента массива меньше или равна трём символам, то записываем его в пустой массив, созданный в шаге 2.
3. Выводим новый массив.

## Реализация на языке С#
    string[] SortArray(string[] array)
    {
        int size = array.Length;
        string[] empty = new string[size];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                empty[i] = array[i];
            }
            else
            {
                size = size - 1;
            }
                
        }
        return empty;
    }

    Console.Clear();
    string[] array = new string[] {"all", "my", "friends", "are", "toxic", "all", " ambitionless"};
    string[] rezult = SortArray(array);
    Console.Write("Выводим массив: ");
    Console.WriteLine("[" + string.Join(", ", array) + "]");

    Console.Write("Элементы длины 3 или меньше: ");
    rezult = rezult.Where(x => x != null).ToArray();
    System.Console.WriteLine("[\"" + string.Join("\", \"", rezult) + "\"]");
