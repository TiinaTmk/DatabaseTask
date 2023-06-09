using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ligipääsuload
    {
        [Key]
        public Guid Id { get; set; }
        public Boolean Ligipääsuõigus { get; set; }
        public string? Ligipääsutase { get; set; }
        public DateTime Ligipääsu_alguskp { get; set; }
        public DateTime Ligipääsu_lõppkp { get; set; }
        public string? Kommentaar { get; set; }
    }
}
