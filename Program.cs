using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string fhrase = Console.ReadLine();// ввод фразы
            string fhraseLower = fhrase.ToLower();// перевод фразы в нижний регистр
            string fhraseLowerReplace = fhraseLower.Replace(" ","");// убрал пробелы
            char[] array = fhraseLowerReplace.ToCharArray();// создание массива символов из строки
            Array.Reverse(array);// обратный порядок символов
            string reverseFhrase = new string(array);// новая строка для сравнения со строкой ввода
            if (fhraseLowerReplace == reverseFhrase)
                Console.WriteLine("Введенный текст является палиндромом");
            if (fhraseLowerReplace != reverseFhrase)
                Console.WriteLine("Введенный текст не является палиндромом");
            Console.ReadKey();
        }
    }
}
