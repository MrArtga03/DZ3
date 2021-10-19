using DZ3;
using System;
using System.Collections.Generic;


namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            //инициализируем списки
            List<object> strings = new List<object> { "бейбик" };
            List<object> ints = new List<object> { 1918 };

            //Класс, который содержит только строки
            MyClass myClass1 = new MyClass();
            strings = (List<object>)myClass1.Add(strings, "мармеладки"); //Добавление в массив строки
            strings = (List<object>)myClass1.RemoveAt(strings, 0);       //Удаление в массиве строки

            //Класс, который содержит только числа
            MyClass myClass2 = new MyClass();
            ints = (List<object>)myClass2.Add(ints, 1);      //Добавление в массив числа
            ints = (List<object>)myClass1.RemoveAt(ints, 0); //Удаление в массиве числа




            //Выводим список строк
            for (int i = 0; i < strings.Count; i++)
            {
                Console.Write(strings[i]);
            }

            Console.WriteLine();

            //Выводим список чисел
            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i]);
            }
        }
    }
}

//Интерфейс задающий сигнатуры методам Add и RemoveAt
interface ISignature
{
    object Add(List<object> list, object item);
    object RemoveAt(List<object> list, int item);
}

class MyClass : ISignature
{
    public object Add(List<object> list, object item)
    {
        list.Add(item);
        return list;
    }

    public object RemoveAt(List<object> list, int item)
    {
        list.RemoveAt(item);
        return list;
    }
}
