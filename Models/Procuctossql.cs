using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace PM2Parcial3.Models
{
    [Table("Procutos")]
    public class Procuctossql
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Nombre { get; set; }
        public double Precio { get; set; }
        public string? Foto { get; set; }
    }
}
