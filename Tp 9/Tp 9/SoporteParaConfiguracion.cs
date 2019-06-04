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

        public static void TextoAMorse(string localizacion)
        {
            string frase;

            string textoConvertido = "";

            string fraseConvertida = "";

            FileStream archivoTexto;

            StreamWriter archivoCreado;

            archivoTexto = new FileStream("Morse: "+DateTime.Today+".txt", FileMode.Create);

            File.Move(@"Morse: " + DateTime.Today + ".txt", localizacion + "Morse: " + DateTime.Today + ".txt");

            archivoTexto.Close();
            
            Console.Write("Ingrese una frase EN MINUSCULAS que desee codificar");

            frase = Console.ReadLine();
            
            for (int i = 0; i< frase.Length; i++)
            {
                switch (frase[i])
                {
                    case 'a':
                        {
                            textoConvertido = ".-5";

                            break;
                        }
                    case 'b':
                        {
                            textoConvertido = "-...5";

                            break;
                        }
                    case 'c':
                        {
                            textoConvertido = "-.-.5";

                            break;
                        }
                    case 'd':
                        {
                            textoConvertido = "-..5";

                            break;
                        }
                    case 'e':
                        {
                            textoConvertido = ".5";

                            break;
                        }
                    case 'f':
                        {
                            textoConvertido = "..-.5";

                            break;
                        }
                    case 'g':
                        {
                            textoConvertido = "--.5";

                            break;
                        }
                    case 'h':
                        {
                            textoConvertido = "....5";

                            break;
                        }
                    case 'i':
                        {
                            textoConvertido = "..5";

                            break;
                        }
                    case 'j':
                        {
                            textoConvertido = ".---5";

                            break;
                        }
                    case 'k':
                        {
                            textoConvertido = "-.-5";

                            break;
                        }
                    case 'l':
                        {
                            textoConvertido = ".-..5";

                            break;
                        }
                    case 'm':
                        {
                            textoConvertido = "--5";

                            break;
                        }
                    case 'n':
                        {
                            textoConvertido = "-.5";

                            break;
                        }
                    case 'o':
                        {
                            textoConvertido = "---5";

                            break;
                        }
                    case 'p':
                        {
                            textoConvertido = ".--.5";

                            break;
                        }
                    case 'q':
                        {
                            textoConvertido = "--.-5";

                            break;
                        }
                    case 'r':
                        {
                            textoConvertido = ".-.5";

                            break;
                        }
                    case 's':
                        {
                            textoConvertido = "...5";

                            break;
                        }
                    case 't':
                        {
                            textoConvertido = "-5";

                            break;
                        }
                    case 'u':
                        {
                            textoConvertido = "..-5";

                            break;
                        }
                    case 'v':
                        {
                            textoConvertido = "...-5";

                            break;
                        }
                    case 'w':
                        {
                            textoConvertido = ".--5";

                            break;
                        }
                    case 'x':
                        {
                            textoConvertido = "-..-5";

                            break;
                        }
                    case 'y':
                        {
                            textoConvertido = "-.--5";

                            break;
                        }
                    case 'z':
                        {
                            textoConvertido = "--..5";

                            break;
                        }
                    case ' ':
                        {
                            textoConvertido = "6";

                            break;
                        }
                }

                fraseConvertida = fraseConvertida + textoConvertido;

            }

            archivoCreado = new StreamWriter(localizacion + "Morse: " + DateTime.Today + ".txt");

            archivoCreado.Write(fraseConvertida);

            archivoCreado.Close();
          

        }
    }
}
