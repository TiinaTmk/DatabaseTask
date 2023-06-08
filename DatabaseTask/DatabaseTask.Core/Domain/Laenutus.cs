using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Laenutus
    {
        [Key]
        public Guid Id { get; set; }
        public string? Laenutatav_kaup { get; set; }
        public DateTime Laenutamisekp { get; set; }
        public DateTime Tagastamisekp { get; set; }
        public Töötaja Id { get; set; }
        public string? Kommentaar { get; set; }
        public Töötaja? Töötaja { get; set; }
    }
}