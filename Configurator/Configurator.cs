namespace Configurator
{
    public static class Configurator
    {
        public static T Configure<T>(string @namespace, string separator = "_")
            where T : Config, new()
        {
            T result = new T();
            result.Initialize(@namespace, separator);
            return result;
        }
    }
}