using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Proyecto.Core.Entities
{
    /// <summary>
    /// Representa una opción vinculada a una entidad simple, con validaciones para el nombre y una relación de clave foránea.
    /// </summary>
    public class EntityOption: BaseEntity
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una opción")]
        public int SimpleEntityId { get; set; }

        [ForeignKey("SimpleEntityId")]
        public SimpleEntity? Opcion { get; set; }
    }
}
