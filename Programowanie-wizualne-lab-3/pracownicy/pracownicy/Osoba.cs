using System.Text.Json.Serialization;
using System;
using System.Xml.Serialization;

namespace pracownicy
{
    [Serializable]
    public class Osoba
    {
        [JsonPropertyName("Id")]
        [XmlElement("Id")]
        public int Id { get; set; }

        [JsonPropertyName("FirstName")]
        [XmlElement("FirstName")]
        public string FirstName { get; set; } = string.Empty;

        [JsonPropertyName("LastName")]
        [XmlElement("LastName")]
        public string LastName { get; set; } = string.Empty;

        [JsonPropertyName("Age")]
        [XmlElement("Age")]
        public int Age { get; set; }

        [JsonPropertyName("Position")]
        [XmlElement("Position")]
        public string Position { get; set; } = string.Empty;
    }
}
