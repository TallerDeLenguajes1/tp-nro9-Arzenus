using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helpers
{
    public static class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion()
        {
            BinaryWriter escritorBinario;

            string ubicacion = @"C:\Prueba_De_Binario";

            escritorBinario = new BinaryWriter(new FileStream("Localizacion.dat", FileMode.Create));

            escritorBinario.Write(ubicacion);

            escritorBinario.Close();
        }

        public static string LeerConfiguracion()
        {
            BinaryReader lectorBinario;

            lectorBinario = new BinaryReader(new FileStream("Localizacion.dat", FileMode.Open));

            string localizacion = lectorBinario.ReadString();

            lectorBinario.Close();

            return localizacion;
            
           
        }
    }
}
