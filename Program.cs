using System;

namespace testCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");

            var logPath = @"D:\repos\testCore\taxID_procesado.txt";//System.IO.Path.GetTempFileName();
var logFile = System.IO.File.Create(logPath);
var logWriter = new System.IO.StreamWriter(logFile);


    string[] lines = System.IO.File.ReadAllLines(@"D:\repos\testCore\taxID.txt");

        // Display the file contents by using a foreach loop.
        //System.Console.WriteLine("Contents of WriteLines2.txt = ");
          Console.WriteLine("(");
           logWriter.WriteLine("(");
       foreach (string line in lines)
        {
            // Use a tab to indent each line of the file.
            Console.WriteLine("\t" + "'" + line+ "',");
            logWriter.WriteLine("\t" + "'" + line+ "',");
        }
  Console.WriteLine(")");
   logWriter.WriteLine(")");


    //Console.WriteLine("logPath: " + logPath);
    //Console.WriteLine("logFile: " + logFile.Name + " - " + logFile.ToString()); 
   logWriter.Dispose();
             Console.WriteLine("Fin");
        }
    }
}
