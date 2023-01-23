using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorToDoList.Data
{
    public class ToDoListItem
    {
        public ToDoListItem()
        {
            Tasks = new List<TaskItem>();
        }

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("listDateTime")]
        public string ListDateTime { get; set; }

        [JsonPropertyName("listTitle")]
        public string ListTitle { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }

        [JsonPropertyName("titleColor")]
        public Color TitleColor { get; set; }

        [JsonPropertyName("sortBy")]
        public SortTask Sortby { get; set; } = SortTask.Priority;

        [JsonPropertyName("userDtoId")]
        public Guid UserDtoId { get; set; }

    }        
}
