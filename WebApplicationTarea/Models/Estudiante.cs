using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Estudiante
    {
        [Key]
        public int idEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Sexo { get; set; }

       
        //public Universidad Universidad { get; set; }
    }
}