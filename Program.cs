using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterStartUp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Contains("-startup"))
            {
                List<Programa> data = new List<Programa>();
                try
                {
                    string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                    path = System.IO.Path.GetDirectoryName(path) + "\\startup.bsu";
                    using (var file = File.OpenRead(path))
                    {
                        var reader = new BinaryFormatter();
                        data = (List<Programa>)reader.Deserialize(file);
                    }
                }
                catch (System.IO.FileNotFoundException)
                {
                    return;
                }
                if (data.Count > 0)
                {
                    foreach (Programa p in data)
                    {
                        if(File.Exists(p.caminho))
                        {
                            if (p.delay > 0)
                            {
                                System.Threading.Thread.Sleep(p.delay * 1000);
                            } 
                            System.Diagnostics.Process.Start(p.caminho, p.argumentos);
                        }
                    }
                }
            } 
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new BetterStartUp());
            }
        }
    }
}
