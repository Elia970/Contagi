using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using cesaretti.elia._4j.contagi.Models;

namespace cesaretti.elia._4j.contagi.Models
{
    class Contagi
    {
        public string data;
        public int progressivo;
        public int contagi;
        public Contagi(string DataI,int ProgressivoI,int ContagiI)
        {
            data = DataI;
            progressivo = ProgressivoI;
            contagi = ContagiI;
        }
        public string Visualizza()                                      //Stamoa in modo ordinato
        {
            return progressivo + ")      " + data + "==> " + contagi;
        }
    }
}
