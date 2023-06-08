using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Firma
    {
        [Key]
        public Guid Id { get; set; }
        public int Registrinr { get; set; }
        public string? Lühinimi { get; set; }
        public string? Koduleht { get; set; }
        public string? Aadress { get; set; }
        public string? Kontaktisik { get; set; }
        public int Kontaktnr { get; set; }
        public string? Email { get; set; }
        public Töötaja? Töötaja { get; set; }
        public Harukontor? Harukontor { get; set; }
     
    }
}
