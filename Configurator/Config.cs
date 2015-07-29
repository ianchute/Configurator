using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Reflection;

namespace Configurator
{
    public abstract class Config
    {
        NameValueCollection _;

        public Config() { }

        public void Initialize(string @namespace = "", string separator = "_")
        {
            _ = ConfigurationManager.AppSettings;

            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                string fullKey = string.Join(separator, @namespace, property.Name);
                Type type = property.PropertyType;

                try
                {
                    object value = Get(fullKey, type);
                    property.SetValue(this, value);
                }
                catch
                {
                }
            }
        }

        protected T Get<T>(string key)
        {
            return (T)Get(key, typeof(T));
        }

        protected object Get(string key, Type type)
        {
            string value = _[key];

            if (type == typeof(string)) return value;
            if (type == typeof(char)) return char.Parse(value);
            if (type == typeof(double)) return double.Parse(value);
            if (type == typeof(int)) return int.Parse(value);

            throw new FormatException(string.Format("Type {0} is not currently supported.", type.Name));
        }
    }
}