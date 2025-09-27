namespace GeniusIdiotConsoleApp
{
    class FileManager
    {
        public static void WriteToFile(string result, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(result);
            }
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

        public static void ShowAll(string path)
        {
            IEnumerable<string> lines = FileManager.ReadFile(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}