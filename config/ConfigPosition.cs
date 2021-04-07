using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Be.MiniClock.config
{
    [Serializable]
    public class ConfigPosition : ICloneable
    {
        public ConfigPosition() { }

        public ConfigPosition(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }


        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        public int Y { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public object Clone()
        {
            return new ConfigPosition(Name, X, Y);
        }
    }
}
