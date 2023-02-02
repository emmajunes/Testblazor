using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorToDoList.Data
{

    public class TaskItem
    {

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("taskPrio")]
        [Required]
        public Priority TaskPrio { get; set; }

        [JsonPropertyName("taskTitle")]
        [MinLength(1, ErrorMessage = "Tasktitle cannot be empty")]
        [Required]
        public string TaskTitle { get; set; }

        [JsonPropertyName("taskDescription")]
        public string TaskDescription { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; }

        [JsonPropertyName("toDoListDtoId")]
        public Guid ToDoListDtoId { get; set; }
    }
}
