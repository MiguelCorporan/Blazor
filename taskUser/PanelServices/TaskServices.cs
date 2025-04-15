/*namespace taskUser.PanelServices
{
    public class TaskServices
    {
    }
}
*/

using Microsoft.EntityFrameworkCore;
using taskUser.Data;
using taskUser.Models;

namespace taskUser.PanelServices
{
    public class TaskService
    {
        private readonly TareasAppContext _context;

        public TaskService(TareasAppContext context)
        {
            _context = context;
        }

        // Método para crear una nueva tarea
        public async Task<ResponseModel> CrearTarea(Tarea tarea)
        {
            try
            {
                // Validar si los campos son correctos
                if (string.IsNullOrEmpty(tarea.Titulo) || string.IsNullOrEmpty(tarea.Descripcion))
                {
                    return new ResponseModel { Success = false, Message = "Por favor, complete todos los campos." };
                }

                // Agregar la tarea a la base de datos
                Console.WriteLine(tarea);
                _context.Tareas.Add(tarea);
                await _context.SaveChangesAsync();

                return new ResponseModel { Success = true, Message = "Tarea creada con éxito." };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Success = false, Message = $"Error: {ex.Message}" };
            }
        }

        // Método para obtener las tareas de un usuario
        public async Task<List<Tarea>> ObtenerTareasPorUsuario(int adminId)
        {
            return await _context.Tareas.Where(t => t.AdminInfoId == adminId).ToListAsync();
        }
    }
}
