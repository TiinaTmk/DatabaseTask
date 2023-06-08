using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ametinimetused
    {
        [Key]
        public Guid Id { get; set; }
        public Töötaja? Id { get; set; }
        public string? Ametinimetus { get; set; }
        public DateTime Ametis_alates { get; set; }
        public DateTime Ametis_kuni { get; set; }
        public string? Osakond { get; set; }
        public string? Otsese_ülemuse_eesnimi { get; set; }
        public string? Otsese_ülemuse_perenimi { get; set; }
        public int Otsese_ülemuse_telefon { get; set; }
        public string? Otsese_ülemuse_email { get; set; }
        public string? Kommentaar { get; set; }
        public Töötaja? Töötaja { get; set; }
    }
}