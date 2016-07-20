using System;

namespace ReflectionTraining2
{
    class Program
    {
        static void Main()
        {
            FileReader file = new FileReader("C:/Users/gnygl/Desktop/Paximum.Content.Messages.dll");
            FileWriter fileWriter = new FileWriter("C:/Users/gnygl/Desktop/dllici/", file.SourceFile);
            fileWriter.Write();
        }
    }
}