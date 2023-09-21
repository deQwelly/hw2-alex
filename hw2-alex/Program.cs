using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_alex
{
    internal class Program
    {
        static bool CanIParse(string number)
        {
            try
            { 
                double.Parse(number);
                return true;
            }
            catch { return false; }
        }

        static void Main(string[] args)
        {
            /// Упражнение 2.1
            Console.WriteLine("Упражнение 2.1: Написать программу, которая спрашивает имя пользователя, и затем\r\n" +
                "приветствует пользователя по имени. (Создать консольное приложение.)");
            Console.Write("Введите ваше имя и нажмите enter: ");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name + "!");

            /// Упражнение 2.2
            Console.WriteLine("\nУпражнение 2.2: Написать программу, которой на вход подается два целых числа, на\r\n" +
                "выходе – результат деления одного числа на другое. Предусмотреть обработку\r\nисключительной ситуации, " +
                "возникающей при делении числа на ноль.");
            Console.Write("Введите делитель и нажмите enter: ");
            string dividend = Console.ReadLine().Replace(".", ",");
            Console.Write("Введите делимое и нажмите enter: ");
            string divider = Console.ReadLine().Replace(".", ",");
            if (CanIParse(dividend))
            {
                if (CanIParse(divider))
                {
                    double diver = double.Parse(divider);
                    if (diver == 0) { Console.WriteLine("Ошибка! Вы делите на 0"); }
                    else { Console.WriteLine("Частное: {0}", double.Parse(dividend) / diver); }
                }
                else { Console.WriteLine("Вы ввели недопустимые символы"); }
            }
            else { Console.WriteLine("Вы ввели недопустимые символы"); }

            /// Домашнее задание 2.1
            Console.WriteLine("\nДомашнее задание 2.1: Прочитать букву с экрана и " +
                "вывести на печать следующую за ней\r\nбукву в алфавитном порядке.");
            Console.WriteLine("Введите любую букву русского или латинского алфавита и нажмите enter: ");
            string word = Console.ReadLine();
            if (word.Length != 1) { Console.WriteLine("Вы ввели более одного символа или не ввели вовсе"); }
            else
            {
                char letter = Convert.ToChar(word);
                if (letter.Equals('z') | letter.Equals('Z') | letter.Equals('я') | letter.Equals('Я'))
                {
                    if (letter.Equals('z')) { Console.WriteLine('a'); }
                    if (letter.Equals('Z')) { Console.WriteLine('A'); }
                    if (letter.Equals('я')) { Console.WriteLine("а"); }
                    if (letter.Equals('Я')) { Console.WriteLine('А'); }
                }
                else { Console.WriteLine("Следующий символ алфавита: " + Convert.ToChar(Convert.ToUInt16(letter) + 1)); }
            }

            /// Домашнее задание 2.2
            Console.WriteLine("\nДомашнее задание 2.2: Написать программу, которая решает квадратное уравнение." +
                "\r\nВходные данные – коэффициенты уравнения, выходные – найденные корни.");
            Console.WriteLine("Введите коэффициенты квадратного уравнения a, b и c соответственно " +
                "(после каждого введенного значения нажмите enter): ");
            string a = Console.ReadLine().Replace(".", ",");
            string b = Console.ReadLine().Replace(".", ",");
            string c = Console.ReadLine().Replace(".", ",");
            if (CanIParse(a))
            {
                if (CanIParse(b))
                {
                    if (CanIParse(c))
                    {
                        double d_a = double.Parse(a);
                        double d_b = double.Parse(b);
                        double d_c = double.Parse(c);
                        double d = (d_b * d_b) - (4 * d_a * d_c);
                        if (d < 0) { Console.WriteLine("Уравнение не имеет вещественных решений"); }
                        else { Console.WriteLine("x1 = {0}\nx2 = {1}", (-d_b + Math.Sqrt(d)) / (2 * d_a), (-d_b - Math.Sqrt(d)) / (2 * d_a)); }
                    }
                    else { Console.WriteLine("Вы ввели недопустимые символы"); }
                }
                else { Console.WriteLine("Вы ввели недопустимые символы"); }
            }
            else { Console.WriteLine("Вы ввели недопустимые символы"); }

            Console.ReadKey();
        }
    }
}