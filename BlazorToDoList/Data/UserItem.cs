using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorToDoList.Data
{
    public class UserItem
    {
        public UserItem()
        {
            ToDoList = new List<ToDoListItem>();
        }

        [JsonPropertyName("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonPropertyName("username")]
        [MinLength(6, ErrorMessage = "Must be atleast 6 characters.")]
        [Required]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        [MinLength(8, ErrorMessage ="Must be atleast 8 characters.")]
        [Required]
        public string Password { get; set; }

        [JsonPropertyName("access")]
        public Access Access { get; set; }

        [JsonPropertyName("sortBy")]
        public SortList SortBy { get; set; } = SortList.Ascendning;

        [JsonPropertyName("toDoList")]
        public ICollection<ToDoListItem> ToDoList { get; set; }

        

    }
}
