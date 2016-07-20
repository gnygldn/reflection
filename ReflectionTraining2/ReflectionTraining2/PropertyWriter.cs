using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTraining2
{
    public class PropertyWriter
    {
        public void WriteProperty(NewPageCreator page, PropertyInfo[] properties)
        {
            foreach (var property in properties)
            {
                page.StreamWriter.WriteLine("\t" + "public" + " " + property.Name + "\n" + "\t" + "{ ");
                var accessors = property.GetAccessors();
                foreach (var accessor in accessors)
                {
                    String[] strings = accessor.Name.Split(Convert.ToChar("_"));
                    page.StreamWriter.WriteLine("\t" + "\t" + strings[0] + "; ");
                }
                page.StreamWriter.WriteLine("\t" + "}");
            }
        }
        
    }
}
