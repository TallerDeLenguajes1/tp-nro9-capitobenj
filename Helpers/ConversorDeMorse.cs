using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helpers
{
    static public class ConversorDeMorse
    {
        public static string MorseATexto(string txtmorse)
        {
            string txt=""; 
            string[] cadena = txtmorse.Split(' ');
            foreach (var letra in cadena)
            {
                switch (letra)
                {
                    case ".-":
                        txt = txt + "a";
                        break;
                    case "-...":
                        txt = txt + "b ";
                        break;
                    case "-.-.":
                        txt = txt + "c";
                        break;
                    case "-..":
                        txt = txt + "d";
                        break;
                    case ".":
                        txt = txt + "e";
                        break;
                    case "..-.":
                        txt = txt + "f";
                        break;
                    case "--.":
                        txt = txt + "g";
                        break;
                    case "....":
                        txt = txt + "h";
                        break;
                    case "..":
                        txt = txt + "i";
                        break;
                    case ".---":
                        txt = txt + "j";
                        break;
                    case "-.-":
                        txt = txt + "k";
                        break;
                    case ".-..":
                        txt = txt + "l";
                        break;
                    case "--":
                        txt = txt + "m";
                        break;
                    case "-.":
                        txt = txt + "n";
                        break;
                    case "---":
                        txt = txt + "o";
                        break;
                    case ".--.":
                        txt = txt + "p";
                        break;
                    case "--.-":
                        txt = txt + "q";
                        break;
                    case ".-.":
                        txt = txt + "r";
                        break;
                    case "...":
                        txt = txt + "s";
                        break;
                    case "-":
                        txt = txt + "t";
                        break;
                    case "..-":
                        txt = txt + "u";
                        break;
                    case "...-":
                        txt = txt + "v";
                        break;
                    case ".--":
                        txt = txt + "w";
                        break;
                    case "-..-":
                        txt = txt + "x";
                        break;
                    case "-.--":
                        txt = txt + "y";
                        break;
                    case "--..":
                        txt = txt + "z";
                        break;
                    case "///":
                        txt = txt + " ";
                        break;
                }
            }
            return txt;
        }
        static public string TextoAMorse(string txt)
        {
            string morse="";
            foreach (var letra in txt)
            {
                switch (letra)
                {
                    case 'a':
                        morse += ".- ";
                        break;
                    case 'b':
                        morse = morse + "-... ";
                        break;
                    case 'c':
                        morse = morse + "-.-. ";
                        break;
                    case 'd':
                        morse = morse + "-.. ";
                        break;
                    case 'e':
                        morse = morse + ". ";
                        break;
                    case 'f':
                        morse = morse + "..-. ";
                        break;
                    case 'g':
                        morse = morse + "--. ";
                        break;
                    case 'h':
                        morse = morse + ".... ";
                        break;
                    case 'i':
                        morse = morse + ".. ";
                        break;
                    case 'j':
                        morse = morse + ".--- ";
                        break;
                    case 'k':
                        morse = morse + "-.- ";
                        break;
                    case 'l':
                        morse = morse + ".-.. ";
                        break;
                    case 'm':
                        morse = morse + "-- ";
                        break;
                    case 'n':
                        morse = morse + "-. ";
                        break;
                    case 'o':
                        morse = morse + "--- ";
                        break;
                    case 'p':
                        morse = morse + ".--. ";
                        break;
                    case 'q':
                        morse = morse + "--.- ";
                        break;
                    case 'r':
                        morse = morse + ".-. ";
                        break;
                    case 's':
                        morse = morse + "... ";
                        break;
                    case 't':
                        morse = morse + "- ";
                        break;
                    case 'u':
                        morse = morse + "..- ";
                        break;
                    case 'v':
                        morse = morse + "...- ";
                        break;
                    case 'w':
                        morse = morse + ".-- ";
                        break;
                    case 'x':
                        morse = morse + "-..- ";
                        break;
                    case 'y':
                        morse = morse + "-.-- ";
                        break;
                    case 'z':
                        morse = morse + "--.. ";
                        break;
                    case ' ':
                        morse = morse + " /// ";
                        break;
                }
            }
            return morse;
        }
        public static void MorseAudio(string morse,string ruta)
        {
            using (var fs = File.OpenWrite(ruta + @"\morse.mp3"))
            {
                foreach (char mor in morse)
                {
                    if (mor == '.')
                    {
                        var buffer = File.ReadAllBytes(ruta + @"\punto.mp3");
                        fs.Write(buffer, 0, buffer.Length);
                        fs.Flush();
                    }
                    else if (mor == '-')
                    {
                        var buffer = File.ReadAllBytes(ruta + @"\raya.mp3");
                        fs.Write(buffer, 0, buffer.Length);
                        fs.Flush();
                    }
                }
                fs.Close();
            }

        }
    }
}
