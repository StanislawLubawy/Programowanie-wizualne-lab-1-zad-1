using System;
using System.Xml.Serialization;

namespace pracownicy
{
    [Serializable]
    public class Osoba
    {
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("FirstName")]
        public string FirstName { get; set; } = string.Empty;

        [XmlElement("LastName")]
        public string LastName { get; set; } = string.Empty;

        [XmlElement("Age")]
        public int Age { get; set; }

        [XmlElement("Position")]
        public string Position { get; set; } = string.Empty;
    }
}