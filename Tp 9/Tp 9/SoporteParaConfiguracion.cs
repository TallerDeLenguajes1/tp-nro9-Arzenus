using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;

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

            StreamWriter archivoCreado;

            FileStream archivoTexto = new FileStream(localizacion + "\\Morse= " + DateTime.Today.ToString("dddd, dd MMMM yyyy") + ".txt", FileMode.Create);
            
            archivoTexto.Close();

            //File.Move(@"Morse= " + DateTime.Today + ".txt", localizacion + @"\Morse= " + DateTime.Today.ToString("dddd, dd MMMM yyyy") + ".txt");
            
            Console.Write("Ingrese una frase EN MINUSCULAS que desee codificar: ");

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

            archivoCreado = new StreamWriter(localizacion + "\\Morse= " + DateTime.Today.ToString("dddd, dd MMMM yyyy") + ".txt");

            archivoCreado.Write(fraseConvertida);

            archivoCreado.Close();
        }

        public static void MorseATexto(string localizacion)
        {
            string linea = "";

            string textoMorse;

            string fraseTraducida = "";

            StreamWriter archivoCreado;

            FileStream textoTraducido = new FileStream(localizacion + "\\Texto= " + DateTime.Today.ToString("dddd, dd MMMM yyyy") + ".txt", FileMode.Create);

            //File.Move(@"Texto= " + DateTime.Today + ".txt", localizacion + @"\Texto= " + DateTime.Today.ToString("dddd, dd MMMM yyyy") + ".txt");

            textoTraducido.Close();

            StreamReader archivoTexto = new StreamReader(localizacion + "\\Morse= " + DateTime.Today.ToString("dddd, dd MMMM yyyy") + ".txt");
            textoMorse = archivoTexto.ReadToEnd();

            for(int i= 0; i< textoMorse.Length; i++)
            {
                if(textoMorse[i] == '5')
                {
                    switch(linea)
                    {
                        case ".-":
                            Console.Write("a");
                            fraseTraducida = fraseTraducida + 'a';
                            break;

                        case "-...":
                            Console.Write("b");
                            fraseTraducida = fraseTraducida + 'b';
                            break;

                        case "-.-.":
                            Console.Write("c");
                            fraseTraducida = fraseTraducida + 'c';
                            break;

                        case "-..":
                            Console.Write("d");
                            fraseTraducida = fraseTraducida + 'd';
                            break;

                        case ".":
                            Console.Write("e");
                            fraseTraducida = fraseTraducida + 'e';
                            break;

                        case "..-.":
                            Console.Write("f");
                            fraseTraducida = fraseTraducida + 'f';
                            break;

                        case "--.":
                            Console.Write("g");
                            fraseTraducida = fraseTraducida + 'g';
                            break;

                        case "....":
                            Console.Write("h");
                            fraseTraducida = fraseTraducida + 'h';
                            break;

                        case "..":
                            Console.Write("i");
                            fraseTraducida = fraseTraducida + 'i';
                            break;

                        case ".---":
                            Console.Write("j");
                            fraseTraducida = fraseTraducida + 'j';
                            break;

                        case "-.-":
                            Console.Write("k");
                            fraseTraducida = fraseTraducida + 'k';
                            break;

                        case ".-..":
                            Console.Write("l");
                            fraseTraducida = fraseTraducida + 'l';
                            break;

                        case "--":
                            Console.Write("m");
                            fraseTraducida = fraseTraducida + 'm';
                            break;

                        case "-.":
                            Console.Write("n");
                            fraseTraducida = fraseTraducida + 'n';
                            break;

                        case "---":
                            Console.Write("o");
                            fraseTraducida = fraseTraducida + 'o';
                            break;

                        case ".--.":
                            Console.Write("p");
                            fraseTraducida = fraseTraducida + 'p';
                            break;

                        case "--.-":
                            Console.Write("q");
                            fraseTraducida = fraseTraducida + 'q';
                            break;

                        case ".-.":
                            Console.Write("r");
                            fraseTraducida = fraseTraducida + 'r';
                            break;

                        case "...":
                            Console.Write("s");
                            fraseTraducida = fraseTraducida + 's';
                            break;

                        case "-":
                            Console.Write("t");
                            fraseTraducida = fraseTraducida + 't';
                            break;

                        case "..-":
                            Console.Write("u");
                            fraseTraducida = fraseTraducida + 'u';
                            break;

                        case "...-":
                            Console.Write("v");
                            fraseTraducida = fraseTraducida + 'v';
                            break;

                        case ".--":
                            Console.Write("w");
                            fraseTraducida = fraseTraducida + 'w';
                            break;

                        case "-..-":
                            Console.Write("x");
                            fraseTraducida = fraseTraducida + 'x';
                            break;

                        case "-.--":
                            Console.Write("y");
                            fraseTraducida = fraseTraducida + 'y';
                            break;

                        case "--..":
                            Console.Write("z");
                            fraseTraducida = fraseTraducida + 'z';
                            break;
                    }

                    linea = "";
                }

                if (textoMorse[i] == '6')
                {
                    Console.Write(" ");
                    fraseTraducida = fraseTraducida + ' ';

                    linea = "";
                }

                else
                {
                    if (textoMorse[i] != '5')
                    {
                        linea = linea + textoMorse[i];
                    }
                }
            }

            archivoCreado = new StreamWriter(localizacion + "\\Texto= " + DateTime.Today.ToString("dddd, dd MMMM yyyy") + ".txt");

            archivoCreado.Write(fraseTraducida);

            archivoCreado.Close();
        }

        public static void MorseAAudio(string localizacion)
        {
            string codigoMorse;

            WindowsMediaPlayer reproductor = new WindowsMediaPlayer();

            StreamReader archivoTexto = new StreamReader(localizacion + "\\Morse= " + DateTime.Today.ToString("dddd, dd MMMM yyyy") + ".txt");
            codigoMorse = archivoTexto.ReadToEnd();

            for (int i = 0; i< codigoMorse.Length; i ++)
            {
                if (codigoMorse[i] != '5')
                {
                    if (codigoMorse[i] == '-')
                    {
                        reproductor.URL = "raya.mp3";
                        reproductor.controls.play();
                    }
                    if (codigoMorse[i] == '.')
                    {
                        reproductor.URL = "punto.mp3";
                        reproductor.controls.play();
                    }

                    //Cargar el mp3 en un binario, concatenar todos los puntos/rayas, guardar
                }
            }
        }
    }
}
