using System.IO;

namespace ReflectionTraining2
{
    public class NewPageCreator
    {
        public FileStream FileStream;
        public StreamWriter StreamWriter;

        public NewPageCreator(string location)
        {
            FileStream = CreateNewCsharpFile(location);
            StreamWriter = new StreamWriter(FileStream);
        }

        public FileStream CreateNewCsharpFile(string location)
        {
            return new FileStream(location, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }
    }
}