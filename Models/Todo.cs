using System.ComponentModel.DataAnnotations;

namespace TodoListApi.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }
    }
}
