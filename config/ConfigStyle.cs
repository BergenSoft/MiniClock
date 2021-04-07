using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Be.MiniClock.config
{
    [Serializable]
    public class ConfigStyle : ICloneable
    {
        private string m_timeFormat;

        public ConfigStyle()
        {
            Name = "Standard";
            TimeFormat = "HH:mm:ss";
            FontName = "Calibri";
            FontSize = 12;
            Bold = true;
            Underline = false;
            Italic = false;
            Strikeout = false;
            FontColor = Color.White;
            ShadowColor = Color.Black;
            ShadowWidth = 3;
            ShadowStrength = 20;
            HAlign = StringAlignment.Near;
            VAlign = StringAlignment.Near;
        }

        public ConfigStyle(string name)
            : this()
        {
            Name = name;
        }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlElement]
        public string TimeFormat
        {
            get
            {
                return m_timeFormat;
            }

            set
            {
                m_timeFormat = value;
                TimeFormatUse = value.Replace("\\n", "\n");
            }
        }

        [XmlIgnore]
        public string TimeFormatUse { get; private set; }

        [XmlElement]
        public string FontName { get; set; }

        [XmlElement]
        public float FontSize { get; set; }

        [XmlElement]
        public bool Bold { get; set; }

        [XmlElement]
        public bool Underline { get; set; }

        [XmlElement]
        public bool Italic { get; set; }

        [XmlElement]
        public bool Strikeout { get; set; }

        [XmlIgnore]
        public Color FontColor { get; set; }

        [XmlElement("FontColor")]
        public string FontColorString
        {
            get
            {
                return "#" + FontColor.R.ToString("X2") + FontColor.G.ToString("X2") + FontColor.B.ToString("X2");
            }

            set
            {
                try
                {
                    FontColor = Color.FromArgb(int.Parse(value.Substring(1, 2), NumberStyles.HexNumber), int.Parse(value.Substring(3, 2), NumberStyles.HexNumber), int.Parse(value.Substring(5, 2), NumberStyles.HexNumber));
                }
                catch (Exception) { }
            }
        }

        [XmlIgnore]
        public Color ShadowColor { get; set; }

        [XmlElement("ShadowColor")]
        public string ShadowColorString
        {
            get
            {
                return "#" + ShadowColor.R.ToString("X2") + ShadowColor.G.ToString("X2") + ShadowColor.B.ToString("X2");
            }

            set
            {
                try
                {
                    ShadowColor = Color.FromArgb(int.Parse(value.Substring(1, 2), NumberStyles.HexNumber), int.Parse(value.Substring(3, 2), NumberStyles.HexNumber), int.Parse(value.Substring(5, 2), NumberStyles.HexNumber));
                }
                catch (Exception) { }
            }
        }

        [XmlElement]
        public int ShadowWidth { get; set; }

        [XmlElement]
        public int ShadowStrength { get; set; }

        [XmlElement]
        public StringAlignment HAlign { get; set; }

        [XmlElement]
        public StringAlignment VAlign { get; set; }

        public object Clone()
        {
            ConfigStyle style = new ConfigStyle();

            style.Name = Name;
            style.TimeFormat = TimeFormat;
            style.FontName = FontName;
            style.FontSize = FontSize;
            style.Bold = Bold;
            style.Underline = Underline;
            style.Italic = Italic;
            style.Strikeout = Strikeout;
            style.FontColor = FontColor;
            style.ShadowColor = ShadowColor;
            style.ShadowWidth = ShadowWidth;
            style.ShadowStrength = ShadowStrength;
            style.HAlign = HAlign;
            style.VAlign = VAlign;

            return style;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
