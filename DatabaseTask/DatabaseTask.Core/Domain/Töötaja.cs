using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Töötaja
    {
        [Key]
        public Guid Id { get; set; }
        public string? Eesnimi { get; set; }
        public string? Perenimi { get; set; }
        public int Isikukood { get; set; }
        public string? Kontaktaadress { get; set; }
        public int Kontakttelefon { get; set; }
        public string? Kontakt_email { get; set; }
        public DateTime Tööl_alates { get; set; }
        public DateTime Tööl_kuni { get; set; }
        public string? Ametinimetuse_Id { get; set; }
        public string? Firma_Id { get; set; }
        public string? Harukontor_Id { get; set; }
        public string? Kommentaar { get; set; }

        public ICollection<Lapsed> Lapsed { get; set }