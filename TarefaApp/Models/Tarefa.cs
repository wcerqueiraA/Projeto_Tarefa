using System.ComponentModel.DataAnnotations;

namespace TarefaApp.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
    }
}
