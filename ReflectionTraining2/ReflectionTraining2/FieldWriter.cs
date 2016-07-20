using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTraining2
{
    class FieldWriter
    {
        public void WriteField(NewPageCreator page, FieldInfo[] fields)
        {
            foreach (var field in fields)
            {
                page.StreamWriter.WriteLine("\t" + "public" + " " + field.FieldType + " " + field.Name + ";\n");
            }
        } 
        
        
    }
}
