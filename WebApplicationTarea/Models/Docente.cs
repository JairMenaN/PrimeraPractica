using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Docente
    {
        [Key]
        public int idDocente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ubicacion { get; set; }
        public bool Sexo { get; set; }
        public string CI { get; set; }
       
        //public Universidad Universidad { get; set; }
    }
}
