using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Tervisekontroll
    {
        [Key]
        public Guid Id { get; set; }
        public Boolean Tervisekontrolli_vajadus { get; set; }
        public DateTime Eelmise_tervisekontrolli_kp { get; set; }
        public DateTime Uue_tervisekontrolli_kp { get; set; }
        public string? Kommentaar { get; set; }
        public Employee? Employees { get; set; }
    }
}
