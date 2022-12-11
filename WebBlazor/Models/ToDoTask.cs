using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class ToDoTask
    {
        public Guid TaskId{get; set;}

        [Required(ErrorMessage = "Campo Task es Requerido")]
        [StringLength(20)]       
        public string Description {get; set;}
        public TaskState TaskState {get; set;}
        public DateTime DateCreated {get; set;} = DateTime.Now;

    }

    public enum TaskState
    {
        Activo,
        Inactivo,
        Terminado
    }
}