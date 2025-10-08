using Newtonsoft.Json;
using System.Text;

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
        //всё ок
        public static void Replace(string path, string value)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                sw.Write(value);
            }
        }

        public static void WriteAllLines(IEnumerable<string> lines, string path)
        {
            File.WriteAllLines(path, lines, System.Text.Encoding.UTF8);
        }
        //всё ок
        public static string GetAll(string path)
        {
            if (!File.Exists(path))
            {
                return string.Empty;
            }
            return File.ReadAllText(path, System.Text.Encoding.UTF8);
        }
        // сериализация
        public static void SerializeToFile<T>(T obj, string path)
        {
            string jsonData = JsonConvert.SerializeObject(obj, Formatting.Indented);
            FileManager.Replace(jsonData, path);
        }
        // десериализация
        public static T DeserializeFromFile<T>(string path)
        {
            string contentFile = FileManager.GetAll(path);
            return JsonConvert.DeserializeObject<T>(contentFile);
        }
    }
}