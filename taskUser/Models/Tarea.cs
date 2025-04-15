namespace taskUser.Models
{
    /*   public class Tarea
       {
       }*/
    public class Tarea
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Completada { get; set; } = false;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        // Relación con AdminInfo (el usuario)
        public int AdminInfoId { get; set; }
        public AdminInfo AdminInfo { get; set; }
    }
}
