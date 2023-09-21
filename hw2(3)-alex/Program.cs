using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace hw2_3__alex
{
    public struct User
    {
        public string name;
        public byte age;
        public uint pin;
    }

    struct Student
    {
        public string first_name;
        public string second_name;
        public int identificator;
        public string birth_date;
        public char alcoholism_category;
        public int volume_alcohol;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /// Задание 1
            Console.WriteLine("Задание 1: Выведите на экран информацию о каждом типе данных в виде:\r\n" +
                "Тип данных – максимальное значение – минимальное значение");
            Console.WriteLine($"byte: максимальное ({byte.MaxValue}), минимальное ({byte.MinValue})");
            Console.WriteLine($"sbyte: максимальное ({sbyte.MaxValue}), минимальное ({sbyte.MinValue})");
            Console.WriteLine($"short: максимальное ({short.MaxValue}), минимальное ({short.MinValue})");
            Console.WriteLine($"ushort: максимальное ({ushort.MaxValue}), минимальное ({ushort.MinValue})");
            Console.WriteLine($"int: максимальное ({int.MaxValue}), минимальное ({int.MinValue})");
            Console.WriteLine($"uint: максимальное ({uint.MaxValue}), минимальное ({uint.MinValue})");
            Console.WriteLine($"long: максимальное ({long.MaxValue}), минимальное ({long.MinValue})");
            Console.WriteLine($"ulong: максимальное ({ulong.MaxValue}), минимальное ({ulong.MinValue})");
            Console.WriteLine($"float: максимальное ({float.MaxValue}), минимальное ({float.MinValue})");
            Console.WriteLine($"double: максимальное ({double.MaxValue}), минимальное ({double.MinValue})");
            Console.WriteLine($"decimal: максимальное ({decimal.MaxValue}), минимальное ({decimal.MinValue})");

            /// Задание 2
            Console.WriteLine("\nЗадание 2: Напишите программу, в которой принимаются данные пользователя" +
                " в виде имени,\r\nгорода, возраста и PIN-кода. Далее сохраните все значение в соответствующей\r\n" +
                "переменной, а затем распечатайте всю информацию в правильном формате.");
            User user;
            try
            {
                Console.Write("Введите имя пользователя: ");
                string temp = Console.ReadLine();
                if (temp != "")
                {
                    user.name = temp;
                    Console.Write("Введите возраст пользователя: ");
                    user.age = Convert.ToByte(Console.ReadLine());
                    Console.Write("Введите пинкод пользователя: ");
                    user.pin = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine($"Имя пользователя: {user.name}, возраст пользователя: {user.age}, пин-код пользователя: {user.pin}");
                }
                else { Console.WriteLine("Вы ввели недопустимые значения или не ввели вовсе"); }
            }
            catch { Console.WriteLine("Вы ввели недопустимые значения или не ввели вовсе"); }

            /// Задание 3
            Console.WriteLine("\nЗадание 3: Преобразуйте входную строку: строчные буквы" +
                " замените на заглавные, заглавные – на\r\nстрочные.");
            Console.Write("Введите произвольную строку и нажмите enter: ");
            Array a_str = Console.ReadLine().ToArray();
            string str = "";
            if (a_str.Length == 0) { Console.WriteLine("Вы ввели пустую строку"); }
            else
            {
                try
                {
                    for (int i = 0; i < a_str.Length; i++)
                    {
                        char temp = (char)a_str.GetValue(i);
                        if (temp < Convert.ToChar((temp.ToString()).ToLower())) { str += (temp.ToString()).ToLower(); }
                        else { str += (temp.ToString()).ToUpper(); }
                        /* Текущее значение символа я сравниваю с его "маленьким" значением.
                        Таким образом, если текущее значение окажется меньше значения "маленького",
                        то символ оказался заглавным, и наоборот. */
                    }
                    Console.WriteLine(str);
                } 
                catch { Console.WriteLine("Вы ввели недопустимые символы"); }
            }

            /// Задание 4
            Console.WriteLine("\nЗадание 4: Введите строку, введите подстроку." +
                " Необходимо найти количество вхождений и вывести\r\nна экран.");
            Console.Write("Введите произвольную строку и нажмите enter: ");
            str = Console.ReadLine();
            if (str == "") { Console.WriteLine("Вы ввели пустую строку"); }
            else
            {
                try
                {
                    Console.Write("Введите подстроку и нажмите enter: ");
                    string sub_str = Console.ReadLine();
                    if (sub_str == "") { Console.WriteLine("Указанная подстрока пуста => не встречается в строке"); }
                    else
                    {
                        string temp_str = str.Replace(sub_str, "");
                        Console.WriteLine($"Указанная подстрока встечается в строке {(str.Length - temp_str.Length) / (sub_str.Length)} раз(а)");
                    }
                }
                catch { Console.WriteLine("Вы ввели недопустимые символы"); }
            }

            /// Задание 5
            Console.WriteLine("\nЗадание 5: Цель этой задачи - определить, сколько бутылок виски беспошлинной" +
                " торговли вам\r\nнужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически" +
                "\r\nпокрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),\r\nскидка в" +
                " Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка\r\nобычно стоит 10" +
                " фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы\r\nсэкономите 1 фунт стерлингов на каждой" +
                " бутылке. Если ваш отпуск стоит 500 фунтов\r\nстерлингов, ответ, который вы должны вернуть, будет 500." +
                " Все входные данные будут\r\nцелыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.");
            try
            {
                Console.Write("Введите цену на виски (целое число рублей) и нажмите enter: ");
                int normPrice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите скидку на виски (целое число в процентах) и нажмите enter: ");
                int salePrice = Convert.ToInt32(Console.ReadLine());
                if (salePrice > 100) { Console.WriteLine("Скидка не может быть больше 100%"); }
                else
                {
                    Console.Write("Введите стоимость отпуска и нажмите enter: ");
                    int holidayPrice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Для того, чтобы покрыть расходы на отдых скидками на виски вам понадобится " +
                        $"{Convert.ToInt32((double)holidayPrice / ((double)normPrice * ((double)salePrice / 100)))} дней");
                }
            }
            catch { Console.WriteLine("Вы ввели некорректное значение"); }

            /// Задание 6
            Console.WriteLine("\nЗадание 6: Воспроизвести разговор Гарри Поттера и дневника Тома Реддла." +
                " Пользователь\r\nздоровается с консолью. Консоль спрашивает, как зовут пользователя." +
                " Пользователь\r\nназывает имя. Консоль пишет: привет, <имя пользователя>." +
                " После этого пользователь\r\nспрашивает, знает ли консоль что-то о тайной комнате." +
                " Консоль отвечает «Да». После\r\nэтого пользователь спрашивает, может ли рассказать." +
                " Консоль отвечает «Нет». Спустя 5\r\nсекунд консоль дополняет «но могу показать»." +
                " Консоль меняет цвет на любой случайный\r\nцвет.");
            Console.Write(" - Как тебя зовут?\n - ");
            string name = Console.ReadLine();
            if (name != "")
            {
                Console.Write($" - Привет, {name}\n - ");
                string phrase = Console.ReadLine();
                if ((phrase.ToLower().Contains("зна")) & (phrase.ToLower().Contains("тай")) & (phrase.ToLower().Contains("комнат")))
                {
                    Console.Write(" - Да\n - ");
                    phrase = Console.ReadLine();
                    if (phrase.ToLower().Contains("ска"))
                    {
                        Console.WriteLine(" - Нет");
                        Thread.Sleep(5000);
                        Console.WriteLine(" - Но могу показать");
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                        Console.ReadKey();
                        Console.ResetColor();
                    }
                    else { Console.WriteLine("Я не знаю, что тебе ответить"); }
                }
                else { Console.WriteLine("Я не знаю, что тебе ответить"); }
            }
            else { Console.WriteLine("Вы не ввели имя"); }

            /// Задание 7
            
            /// Задание 8
            Console.WriteLine("\nСоздать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, " +
                "Дата\r\nрождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель\r\nвыпить, " +
                "но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у\r\nстудента есть " +
                "Объем выпитого алкоголя. Создать 5 студентов с различными\r\nпараметрами. Посчитать общий объем " +
                "алкоголя и кто сколько процентов выпил.");
            Student student1, student2, student3, student4, student5;
            
            /// 1 студент
            student1.first_name = "Иван";
            student1.second_name = "Иванов";
            student1.identificator = 111;
            student1.birth_date = "01.01.2005";
            student1.alcoholism_category = 'a';
            student1.volume_alcohol = 30;

            /// 2 студент
            student2.first_name = "Петр";
            student2.second_name = "Петров";
            student2.identificator = 222;
            student2.birth_date = "02.01.2005";
            student2.alcoholism_category = 'b';
            student2.volume_alcohol = 15;

            /// 3 студент
            student3.first_name = "Андрей";
            student3.second_name = "Андреев";
            student3.identificator = 333;
            student3.birth_date = "03.01.2005";
            student3.alcoholism_category = 'c';
            student3.volume_alcohol = 7;

            /// 4 студент
            student4.first_name = "Евгений";
            student4.second_name = "Евгеньев";
            student4.identificator = 444;
            student4.birth_date = "04.01.2005";
            student4.alcoholism_category = 'd';
            student4.volume_alcohol = 0;

            /// 5 студент
            student5.first_name = "Борис";
            student5.second_name = "Борисов";
            student5.identificator = 555;
            student5.birth_date = "05.01.2005";
            student5.alcoholism_category = 'a';
            student5.volume_alcohol = 25;

            int volume = student1.volume_alcohol + student2.volume_alcohol + student3.volume_alcohol + student4.volume_alcohol + student5.volume_alcohol;
            Console.WriteLine($"Общий объем выпитого алкоголя: {volume}");
            Console.WriteLine($"Из них первый выпил ~ {Math.Round((double)(student1.volume_alcohol * 100) / volume)}% от общего объема");
            Console.WriteLine($"Из них второй выпил ~ {Math.Round((double)(student2.volume_alcohol * 100) / volume)}% от общего объема");
            Console.WriteLine($"Из них третий выпил ~ {Math.Round((double)(student3.volume_alcohol * 100) / volume)}% от общего объема");
            Console.WriteLine($"Из них четвертый выпил ~ {Math.Round((double)(student4.volume_alcohol * 100) / volume)}% от общего объема");
            Console.WriteLine($"Из них пятый выпил ~ {Math.Round((double)(student5.volume_alcohol * 100) / volume)}% от общего объема");
        }
    }
}
