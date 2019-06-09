using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    class SoporteParaConfiguracion
    {
        static public void CrearArchivoDeConfiguracion()
        {
            string arch = "config.dat";
            string[] drives = Directory.GetLogicalDrives();
            string folder = drives[0] + "nuevo" ;
            BinaryWriter bin = new BinaryWriter(File.Open(arch, FileMode.Create));
            bin.Write(folder);
            bin.Close();
        }
        static public string LeerConfiguracion()
        {
            string config;
            BinaryReader bin =new BinaryReader(File.Open("config.dat", FileMode.Open));
            config = bin.ReadString();
            return config;
        }
    }
}
