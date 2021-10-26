using DZ3;
using System;
using System.Collections.Generic;


namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] myIntArray = new object[] { 1, 2, 3, 4 };                                //Список целочисленных чисел
            object[] myStringArray = new object[] { "GitHub", "КПК", "ХОЧУ 5, ИЛИ НЕТ..." };  //Список Строк

            //Класс, который содержит только числа
            Massiv IntMassiv = new Massiv();
            //myIntArray = (object[])IntMassiv.RemoveAt(ref myIntArray, 2);
            myIntArray = (object[])IntMassiv.Add(ref myIntArray, 0, 3);

            //Класс, который содержит только строки
            Massiv StringMassiv = new Massiv();
            myStringArray = (object[])StringMassiv.RemoveAt(ref myStringArray, 1);
            myStringArray = (object[])StringMassiv.Add(ref myStringArray, "чача", 0);

            //Выводим список целочисленных чисел
            ShowArr(myIntArray);

            Console.WriteLine();

            ShowArr(myStringArray);

            static void ShowArr(object[] arr) { for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");  }
        }
    }
}


class Massiv
{
    public object Add(ref object[] arr, object el, int index)
    {
        object[] newArr = new object[arr.Length + 1];
        newArr[index] = el;

        for (int i = 0; i < arr.Length; i++) newArr[i] = arr[i]; 
        for (int i = index; i < arr.Length; i++) newArr[i + 1] = arr[i];

        arr = newArr;

        return arr;
    }

    public object RemoveAt(ref object[] arr, int index)
    {
        object[] newArr = new object[arr.Length - 1];

        for (int i = 0; i < index; i++) newArr[i] = arr[i]; 
        for (int i = index + 1; i < arr.Length; i++) newArr[i - 1] = arr[i];

        arr = newArr;

        return arr;
    }
}