using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using cesaretti.elia._4j.contagi.Models;

namespace cesaretti.elia._4j.contagi
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader File = new StreamReader("ContagiRimini.json");                      //Uso lo StreamReader per leggere il file json
            string Dati;                                                                    //variabile dove inserisco i dati contenuti nel file json
            Dati = File.ReadToEnd();                                                       //Assegno a Dati i dati presenti nel file json
            Contagi[] Covid = JsonConvert.DeserializeObject<Contagi[]>(Dati);             //Deserializzo l'array di oggetti con i dati
            //Console.WriteLine(Covid[1].Visualizza());
            int Max = Covid[1].contagi;                                                 
            int Min = Covid[1].contagi;
            for ( int i = 2|; i < Covid.Length; i++)
            {
                if (Covid[i].contagi > Max)
                {
                    Max = i;
                }
                else
                {
                    if (Covid[i].contagi < Min)
                    {
                        Min = i;
                    }
                }
            }
            Console.WriteLine("La data in cui si sono verificati il numero maggiore di contagi è " + Covid[Max].data + " con " + Covid[Max].contagi);
            Console.WriteLine("La data in cui si sono verificati il numero minore di contagi è " + Covid[Min].data + " con " + Covid[Min].contagi);
            Console.ReadLine();

        }
    }
}
