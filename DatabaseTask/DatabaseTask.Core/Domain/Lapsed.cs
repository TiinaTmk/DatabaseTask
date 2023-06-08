using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Lapsed
    {
        [Key]
        public Guid Id { get; set; }
        public string? Eesnimi { get; set; }
        public string? Perekonnanimi { get; set; }
        public DateTime Sünniaeg { get; set; }
        public int Vanus { get; set; }
        public string? Kommentaar { get; set; }
        public Töötaja? Töötaja { get; set; }
    }
}
