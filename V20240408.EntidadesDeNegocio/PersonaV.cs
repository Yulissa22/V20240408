using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace V20240408.EntidadesDeNegocio
{
    public class PersonaV
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Required(ErrorMessage ="El nombre es requerido")]
            [StringLength(50)]
            [DisplayName ("Nombre")]
            public string NombreV { get; set; }

            [Required(ErrorMessage = "El apellido es requerido")]
            [StringLength(50)]
            [DisplayName("Apellido")]
            public string ApellidoV { get; set; }

            [Required(ErrorMessage = "La fecha nacimiento es requerida")]
            [DisplayName("Fecha nacimiento")]
            public DateTime FechaNacimientoV { get; set; }

            [Required(ErrorMessage = "El sueldo es requerido")]
            [DisplayName("Sueldo")]
            public decimal sueldoV { get; set; }

            [Required(ErrorMessage = "El estatus es requerido")]
            [DisplayName("Estatus")]
            public byte EstatusV { get; set; }

            [Required(ErrorMessage = "El comentario es requerido")]
            [DisplayName("Comentario")]
            public string ComentarioV { get; set; }
        
    }
}
