using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Заказ
    {
        public DateTime ДатаОплаты { get; set; }
        public Транспорт ПолучениеАвто { get; set; }
        public string Статус { get; set; }
        public decimal Цена { get; set; }
        public Пользователь Клиент { get; set; }

        public Заказ(DateTime датаОплаты, Транспорт получениеАвто, string статус, decimal цена, Пользователь клиент)
        {
            ДатаОплаты = датаОплаты;
            ПолучениеАвто = получениеАвто;
            Статус = статус;
            Цена = цена;
            Клиент = клиент;
        }
    }
}