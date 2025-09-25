namespace GeniusIdiotConsoleApp
{
    class FileManager
    {
        public static void WriteToFile(string result)
        {
            using (StreamWriter sw = new StreamWriter("Журнал тестирования.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(result);
            }
        }

        public static IEnumerable<string> ReadFile()
        {
            try
            {
                IEnumerable<string> lines = File.ReadLines("Журнал тестирования.txt");
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