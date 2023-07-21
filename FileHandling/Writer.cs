using FileHandling.Interfaces;

namespace FileHandling
{
    internal class Writer: IWriter
    {
        public readonly IWriterService _writerService;
        public Writer(IWriterService service)
        {
            this._writerService = service;
        }

        public void WriteToFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
