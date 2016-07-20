using System;
using System.Reflection;

namespace ReflectionTraining2
{
    public class FileWriter
    {
        private string location;
        private Assembly sourceAssembly;

        public FileWriter(string location, Assembly sourceFile)
        {
            this.location = location;
            sourceAssembly = sourceFile;
        }

        public void Write()
        {
            foreach (var type in sourceAssembly.GetTypes())
            {
                if (type.IsClass)
                {
                    ClassWriter myClass = new ClassWriter(location, type);
  

                }
                else if (type.IsEnum)
                {
                   EnumWriter myEnum = new EnumWriter(location,type);
                }

                else if (type.IsValueType)
                {
                    StructWriter myStruct = new StructWriter(location,type);
                }
            }
        }
    }
}