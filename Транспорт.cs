using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Транспорт
    {
        public string ID { get; set; }
        public string Название { get; set; }
        public string Адрес { get; set; }

        public Транспорт(string id, string название, string адрес)
        {
            ID = id;
            Название = название;
            Адрес = адрес;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Название: {Название}, Адрес: {Адрес}";
        }
       
    }
}