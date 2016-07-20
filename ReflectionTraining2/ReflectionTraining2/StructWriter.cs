using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTraining2
{
    public class StructWriter
    {
        public StructWriter(string location, Type type)
        {
            var newPage = new NewPageCreator(location + type.Name + ".cs");
            newPage.StreamWriter.WriteLine("namespace " + type.Namespace + "\n{");

            //string accessType = type.IsPublic ? "public struct" : "class";
            newPage.StreamWriter.WriteLine("public" + " " + type.FullName + " \n{");

            foreach (var enumName in type.GetEnumNames())
            {
                newPage.StreamWriter.WriteLine("\t" + enumName + ",");
            }

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
