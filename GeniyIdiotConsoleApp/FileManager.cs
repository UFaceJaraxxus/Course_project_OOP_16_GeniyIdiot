namespace GeniusIdiotConsoleApp
{
    class FileManager
    {
        public static void WriteToFile(string value, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(value);
            }
        }

        public static void WriteAllFile(IEnumerable<string> lines, string path)
        {
            File.WriteAllLines(path, lines, System.Text.Encoding.Default);
        }

        public static IEnumerable<string> ReadFile(string path)
        {
            try
            {
                IEnumerable<string> lines = File.ReadLines(path);
                return lines;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден!");
            }
            return Enumerable.Empty<string>();
        }
    }
}