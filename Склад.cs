using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Склад : Транспорт
    {
        public List<Транспорт> МассивТранспорта { get; set; } = new List<Транспорт>();

        public void ДобавитьТранспорт(Транспорт транспорт)
        {
            МассивТранспорта.Add(транспорт);
            Количество++;
        }

        
        public int Количество { get; set; }

        public Склад(string id, string название, string адрес, int количество):base(id,название,адрес) 
        {
  
            Количество = количество;
        }
        public void ПолучитьИнформацию()
        {
            Console.WriteLine($"{Название} по адресу {Адрес}, доступно: {Количество}, Айди-{ID}");
        }
        public void ПоказатьДанные()
    {
        foreach (var транспорт in МассивТранспорта)
        {
            Console.WriteLine(транспорт);
        }
    }

    }
}