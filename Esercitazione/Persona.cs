using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    class Persona
    {
        public string nome { get; set; }

        public string cognome { get; set; }
      
        private int _anni;
        public int anni
        {
            get
            {
                return _anni;
            }
            set
            {
                if (value <= 0) value = 1;
                _anni = value;
            }
        }

        public string codiceFiscale
        {
            get
            {
                return nome + cognome + anni;
            }
        }

        public Persona(string nome, string cognome, int anni)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.anni = anni;
        }

        public virtual string describe()
        {
           string output = "Nome: " + nome + "\r\n";
           output += "Cognome: " + cognome + "\r\n";
           output += "Età: " + anni;

           return output;
        }
    }
}
