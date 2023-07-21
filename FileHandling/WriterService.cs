using FileHandling.Interfaces;

namespace FileHandling
{
    internal class WriterService : IWriterService
    {
        public void Write(string filePath, string content)
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(content);
                }
            }
        }
    }
}
