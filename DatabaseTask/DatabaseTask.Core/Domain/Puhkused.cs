using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Puhkused
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public int Puhkuse_päevi_kokku { get; set; }
        public DateTime Puhkuse_algus { get; set; }
        public DateTime Puhkuse_lõpp { get; set; }
        public int Kasutatud_puhkusepäevi { get; set; }
        public int Allesolevaid_puhkusepäevi { get; set; }
        public int Aegunud_puhkusepäevi { get; set; }
        public string? Kommentaar { get; set; }
    }
}
