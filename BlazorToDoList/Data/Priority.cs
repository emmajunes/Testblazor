using System.Text.Json.Serialization;

namespace BlazorToDoList.Data
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Priority
    {
        Low = 0,
        MediumLow = 1,
        Medium = 2,
        MediumHigh = 3,
        High = 4,
    }
}