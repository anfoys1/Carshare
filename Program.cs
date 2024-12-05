using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Каршеринг_сервис
    {
        static void Main()
        {
            
            Пользователь пользователь = new Пользователь("user", "123", "+375297270505", "AB1234567", "Проведена");
            Проверка проверка = new Проверка(пользователь.Логин,пользователь.Пароль,пользователь.Номертелефона,пользователь.Оплата,пользователь.Паспортныеданные
        );
            Console.Write("Введите логин: ");
            string введенныйЛогин = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string введенныйПароль = Console.ReadLine();
            if (проверка.ПроверитьДанные(введенныйЛогин, введенныйПароль))
            {
                Console.WriteLine("Проверка успешна! Вы вошли в систему.");
            }
            else
            {
                Console.WriteLine("Неверный логин или пароль.");
                return;
            }
            Склад склад = new Склад("TR123", "Склад 1", "ул. Лесная, 10",0);
            склад.ДобавитьТранспорт(new Транспорт("1", "Грузовик", "Улица 1"));
            склад.ДобавитьТранспорт(new Транспорт("2", "Легковой", "Улица 2"));
            Заказ заказ = new Заказ(DateTime.Now, склад, "Оформлен", 120, пользователь);
            Console.WriteLine("Нажмите клавишу '1' для показа данных склада.");
            Console.WriteLine("Нажмите клавишу '2' для показа данных пользователя.");
            Console.WriteLine("Нажмите клавишу '3' для показа данных заказа.");
            Console.WriteLine("Нажмите клавишу '4' для показа данных о транспорте.");
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("Данные склада:");
                    склад.ПолучитьИнформацию();

                }
                else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                {
                    Console.WriteLine("Данные Пользователя:");
                    пользователь.Данные();
                }
                else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                {

                    Console.WriteLine($"Заказ оформлен для {заказ.Клиент.Логин}. Общая цена: {заказ.Цена} р.");
                }
                else if (key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4)
                {
                    Console.WriteLine("Данные о транспорте:");
                    склад.ПоказатьДанные();
                    Console.WriteLine("Введите название транспорта и нажмите '1' для добавления:");
                    var addKey = Console.ReadKey(true);
                    if (addKey.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine("Введите id, название и адрес добавляемого транспорта");
                        string id = Console.ReadLine();
                        string название = Console.ReadLine();
                        string адрес = Console.ReadLine();
                        склад.ДобавитьТранспорт(new Транспорт(id, название, адрес));
                        Console.WriteLine($"Транспорт {id}, {название},по адресу {адрес} добавлен.");
                        
                    }
                }
            }
        }
    }
}
