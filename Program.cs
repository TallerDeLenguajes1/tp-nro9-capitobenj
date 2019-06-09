using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace TP9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string config,texto,morse,date;
            date = dateTime.ToString("ddMMyyyy");

            if (File.Exists("config.dat"))
            {
                SoporteParaConfiguracion.CrearArchivoDeConfiguracion();
                config = SoporteParaConfiguracion.LeerConfiguracion();
            }
            else config = SoporteParaConfiguracion.LeerConfiguracion();
            moverarchivos(config);
            Directory.CreateDirectory(config + @"\Morse");
            Directory.CreateDirectory(config + @"\Texto");
            Console.WriteLine("Texto a codificar: ");
            texto =  Console.ReadLine();
            morse = ConversorDeMorse.TextoAMorse(texto);
            File.WriteAllText(config +@"\Morse\morse_["+date+"].txt",morse);
            File.WriteAllText(config+@"\Texto\texto_["+date+"].txt",texto);
            ConversorDeMorse.MorseAudio(morse,config);
        }
        public static void moverarchivos(string config)
        {
            Directory.CreateDirectory(config);
            string dor = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(dor);
            string[] items;
            string exten = ".";
            int f=files.Length;
            int ff;
            for (int cont=0;cont<f ;cont++)
            {
                ff = files[cont].Length;
                exten="."+files[cont].Substring(ff - 3);
                items = files[cont].Split('\\');
                int op = items.Length;
                if (exten == ".mp3" || exten == ".txt")
                {
                    File.Copy(files[cont], config + @"\" + items[op-1]);
                } 
            }
            
        }
    }
}
