using System.Text.Json.Serialization;

namespace BlazorToDoList.Data
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortTask
    {
        Priority = 0,
        Completed = 1
    }
}