using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Проверка : Пользователь
    {
        public Проверка(string логин, string номерТелефона, string оплата, string пароль, string паспортныеДанные)
        : base(логин, номерТелефона, оплата, пароль, паспортныеДанные)
        {
        }
        public bool ПроверитьДанные(string введенныйЛогин, string введенныйПароль)
        {
            return Логин == введенныйЛогин && Пароль == введенныйПароль;
        }
    }
}