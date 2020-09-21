using SQLite.CodeFirst;

namespace AS.Models
{
    class Configerationpanel 
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
