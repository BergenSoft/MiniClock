using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace Be.MiniClock.config
{
    [Serializable]
    public class Config : ICloneable
    {

        public Config()
        {
            Positions = new List<ConfigPosition>();
            Styles = new List<ConfigStyle>();

        }

        [XmlElement]
        public int X { get; set; }

        [XmlElement]
        public int Y { get; set; }

        [XmlArray("Styles")]
        [XmlArrayItem("Style")]
        public List<ConfigStyle> Styles { get; set; }

        [XmlArray("Positions")]
        [XmlArrayItem("Pos")]
        public List<ConfigPosition> Positions { get; set; }

        [XmlElement]
        public int LastStyle { get; set; }

        [XmlIgnore]
        public ConfigStyle CurrentStyle
        {
            get
            {
                if (Styles.Count == 0)
                    Styles.Add(new ConfigStyle("Standard"));

                if (LastStyle >= Styles.Count)
                    LastStyle = Styles.Count - 1;

                return Styles[LastStyle];
            }
        }

        public void Save()
        {
            if (File.Exists(GetConfigPath()))
                File.Delete(GetConfigPath());

            using (StreamWriter filestream = new StreamWriter(File.Open(GetConfigPath(), FileMode.OpenOrCreate, FileAccess.ReadWrite), Encoding.UTF8))
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.IndentChars = "\t";
                settings.Indent = true;
                using (XmlWriter xmlWriter = XmlWriter.Create(filestream, settings))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Config));
                    XmlSerializerNamespaces xmlNamespace = new XmlSerializerNamespaces();
                    xmlNamespace.Add("", "");
                    serializer.Serialize(xmlWriter, this, xmlNamespace);
                }
            }
        }

        public static Config Load()
        {
            try
            {
                using (StreamReader filestream = new StreamReader(File.Open(GetConfigPath(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite), Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Config));
                    return serializer.Deserialize(filestream) as Config;
                }
            }
            catch (Exception)
            { }

            return new Config();
        }

        public static string GetConfigPath()
        {
            string path = Path.Combine(Environment.GetEnvironmentVariable("APPDATA"), "BergenSoft", Assembly.GetExecutingAssembly().GetName().Name);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return Path.Combine(path, "config.xml");
        }


        public object Clone()
        {
            Config cfg = new Config();

            cfg.X = X;
            cfg.Y = Y;
            cfg.LastStyle = LastStyle;

            foreach (ConfigPosition pos in Positions)
            {
                cfg.Positions.Add(pos.Clone() as ConfigPosition);
            }

            foreach (ConfigStyle style in Styles)
            {
                cfg.Styles.Add(style.Clone() as ConfigStyle);
            }
            return cfg;
        }
    }
}
