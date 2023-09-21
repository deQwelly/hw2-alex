using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_2__alex
{
    enum BankAccount { CurrentAccount = 123, SavingAccount = 123123 }

    public struct BankAccountInfo
    {
        public int number;
        public string type;
        public double balance;
    }

    enum University { КГУ = 1, КАИ = 2, КХТИ = 3 }

    public struct Employee
    {
        public string name;
        public string university;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /// Упражнение 3.1
            Console.WriteLine("Упражнение 3.1: Создать перечислимый тип данных отображающий виды банковского\r\n" +
                "счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей\r\n" +
                "значение и вывести это значение на печать.");
            BankAccount account1 = BankAccount.CurrentAccount;
            BankAccount account2 = BankAccount.SavingAccount;
            Console.WriteLine($"Счет: {account1}, сумма на счету: {(int)account1}\n" +
                $"Счет: {account2}, сумма на счету: {(int)account2}");

            /// Упражнение 3.2
            Console.WriteLine("\nУпражнение 3.2: Создать структуру данных, которая хранит информацию о банковском\r\n" +
                "счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру\r\n" +
                "значениями и напечатать результат.");
            BankAccountInfo bank_account;
            try
            {
                Console.Write("Введите номер счета и нажмите enter: ");
                bank_account.number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите тип счета (например, текущий или сберегательный) и нажмите enter: ");
                bank_account.type = Console.ReadLine();
                Console.Write("Введите баланс счета и нажмите enter: ");
                bank_account.balance = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                Console.WriteLine($"Номер счета: {bank_account.number}, тип счета: {bank_account.type}, баланс счета: {bank_account.balance}");
            }
            catch { Console.WriteLine("Вы ввели недопустимые значения, или не ввели их вовсе"); }

            /// Домашнее задание 3.1
            Console.WriteLine("\nДомашнее задание 3.1: Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать\r\n" +
                "структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и\r\nраспечатать.");
            Employee employee;
            try
            {
                Console.Write("Введите имя работника и нажмите enter: ");
                employee.name = Console.ReadLine();
                Console.Write("ВУЗ работника (1 - КГУ, 2 - КАИ, 3 - КХТИ). После ввода нажмите enter: ");
                employee.university = Enum.GetName(typeof(University), Convert.ToByte(Console.ReadLine()));
                Console.WriteLine($"Имя работника: {employee.name}, ВУЗ работника: {employee.university}");
            }
            catch { Console.WriteLine("Вы ввели недопустимые значения, или не ввели их вовсе"); }
        }
    }
}
