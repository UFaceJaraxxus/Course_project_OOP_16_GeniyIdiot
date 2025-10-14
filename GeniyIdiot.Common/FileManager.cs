using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class FileManager
    {
        public static void Write(string value, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(value);
            }
        }

        public static void Replace(string value, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                sw.Write(value);
            }
        }

        public static string GetAll(string path)
        {
            if (!File.Exists(path))
            {
                return string.Empty;
            }
            return File.ReadAllText(path, System.Text.Encoding.UTF8);
        }

        public static void SerializeToFile<T>(T obj, string path)
        {
            string jsonData = JsonConvert.SerializeObject(obj, Formatting.Indented);
            Replace(jsonData, path);
        }

        public static T DeserializeFromFile<T>(string path)
        {
            string contentFile = GetAll(path);
            return JsonConvert.DeserializeObject<T>(contentFile);
        }
    }
}