using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using System.IO;

namespace Tp_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string localizacion = "";

            //string path = @"E:\Taller 1\Repositorios Git\tp-nro9-Arzenus\Tp 9\Tp 9\bin\Debug";

            // string[] archivos = Directory.GetFiles(path);

            /*  for (int i = 0; i < archivos.Length; i++)
              {
                  Console.Write(Path.GetFileName(archivos[i]));
                  Console.Write("\n");
              }

              for (int i = 0; i < archivos.Length; i++)
              {
                  if (Path.GetExtension(archivos[i]) == ".exe")
                  {
                      Console.Write("Es exe\n");
                  }
              }*/

            SoporteParaConfiguracion.CrearArchivoDeConfiguracion();

            localizacion = SoporteParaConfiguracion.LeerConfiguracion();

            SoporteParaConfiguracion.TextoAMorse(localizacion);

            SoporteParaConfiguracion.MorseATexto(localizacion);


            Console.ReadKey();
        }
    }
}
