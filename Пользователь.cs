using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Пользователь 
    {
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public string Номертелефона { get; set; }
        public string Паспортныеданные { get; set; }
        public string Оплата { get; set; }

        
        public Пользователь(string логин, string пароль, string номертелефона, string паспортныеданные, string оплата)
        {
            Логин = логин;
            Пароль = пароль;
            Номертелефона = номертелефона;
            Паспортныеданные = паспортныеданные;
            Оплата = оплата;
        }

        public void Данные()
        {
            Console.WriteLine($"Тел - {Номертелефона} Паспортные - {Паспортныеданные} Оплата - {Оплата}");
        }
    }
}