using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Employee
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


        public ICollection<Ametinimetused>? Ametinimetuseds { get; set; }
        public ICollection<Firma> Firmas { get; set; }
        public ICollection<Haiguslehed> Haigusleheds { get; set; }
        public ICollection<Harukontor> Harukontors { get; set; }
        public ICollection<Laenutus> Laenutused { get; set; }
        public ICollection<Lapsed>? Childrens { get; set; }
        public IEnumerable<Ligipääsuload>? Ligipääsuloads { get; set; } = new List<Ligipääsuload>();
        public ICollection<Puhkused> Puhkuseds { get; set; }
        public ICollection<Tervisekontroll> Tervisekontrolls { get; set; }
       


        
        //public List<Children> Childrens { get; set; }
    }
    //public enum Gender
    //{
    //    Female, 
    //    Male,
    //    Unknown
    //}

    //public class Children
    //{
    //    [Key]
    //    public Guid Id { get; set; }

    //    public string FirstName { get; set; }
    //}
}

