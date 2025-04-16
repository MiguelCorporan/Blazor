
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using taskUser.Models;

namespace taskUser.Models

{
    public class AdminInfo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(30)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(6)]
        public string Password { get; set; } = string.Empty;

        // Relación con las tareas
        public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
    }
}
