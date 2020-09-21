using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.Models
{
    class Nomenclatura
    {
        [Autoincrement]
        public string Код { get; set; }
        public string Наименование { get; set; }
        public string Артикул { get; set; }
        public decimal Цена { get; set; }
        //public Категория Категория { get; set; }
        public int Id { get; set; }
    }
}
