using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTraining2
{
    class ClassWriter
    {
        public ClassWriter(string location,Type type)
        {
            WriteClasses(location,type);
        }
        
        public void WriteClasses(string location,Type type)
        {
            var newPage = new NewPageCreator(location + type.Name + ".cs");
            newPage.StreamWriter.WriteLine("namespace " + type.Namespace + "\n{");

            //string accessType = type.IsPublic ? "public class" : "class";
            newPage.StreamWriter.WriteLine("public" + " " + type.FullName + " \n{");

            FieldWriter field = new FieldWriter();
            field.WriteField(newPage, type.GetFields());
            PropertyWriter property = new PropertyWriter();
            property.WriteProperty(newPage, type.GetProperties());

            ClosePage(newPage);
        }
        
        private void ClosePage(NewPageCreator page)
        {
            page.StreamWriter.WriteLine("}\n}");
            page.StreamWriter.Close();
            page.FileStream.Close();
        }
    }
}
