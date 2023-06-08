using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Haiguslehed
    {
        [Key]
        public Guid Id { get; set; }
        public Töötaja Id { get; set; }
        public Boolean Õigus_haiguslehele { get; set; }
        public int Haiguspäevi_kokku { get; set; }
        public DateTime Haiguslehe_algus { get; set; }
        public DateTime Haiguslehe_lõpp { get; set; }
        public int Kasutatud_haiguspäevi { get; set; }
        public int Allesolevaid_haiguspäevi { get; set; }
        public int Aegunud_haiguspäevi { get; set; }
        public string? Kommentaar { get; set; }
        public Töötaja? Töötaja { get; set; }
    }
}
