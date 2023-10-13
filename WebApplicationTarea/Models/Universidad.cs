using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Universidad
    {
        [Key]
        public int idUniversidad { get; set; }
        public string Nombre { get; set; }

        //public ICollection<Docente> Docente { get; set; }

        //public ICollection<Estudiante> Estudiante { get; set; }
    }


}
