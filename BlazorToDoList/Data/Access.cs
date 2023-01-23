using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BlazorToDoList.Data
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Access
    {
        User = 0,
        Moderator = 1,
        Admin = 2,
    }
}
