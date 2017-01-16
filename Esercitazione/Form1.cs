using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercitazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] nomi = { "Carlo", "Marco", "Luca", "Mario", "Alberto", "Franco", "Fracesco", "Federico", "Mario", "Andrea", "Nicolò", "Gabriele", "Giacomo", "Riccardo", "Simone", "Tommaso", "Matteo", "Daniele", "Emanuele", "Fabio" };
        public string[] cognomi = { "Rossi", "Verdi", "Bianchi", "Neri", "Castelli", "Cortini", "Facocero", "Timon", "Pumba", "Shrek", "Tocci", "Mazzini", "Mordelli", "Toccozzi", "Taccagni", "Bombassi", "Striscioni", "Corbelli", "Pistocchi", "Maraschini", "Spoggi", "Tamarri", "Truzzi", "Giacobelli", "Marmotta" };

        private void Form1_Load(object sender, EventArgs e)
        {
            //Persona p = new Persona(nomi[0], cognomi[0], 29);
            //Studente s = new Studente("Tizio", "Caio", 17, "3F");
            Console.WriteLine(generateRandomPersona());
            Console.WriteLine(generateRandomPersona());
            Console.WriteLine(generateRandomPersona());
        }

        Random rnd = new Random();                                       //   var = rnd.Next(a, b) , then  a <= var < b
        private Persona generateRandomPersona()
        {
            return new Persona(nomi[rnd.Next(0, 20)], cognomi[rnd.Next(0, 25)], rnd.Next(10, 50)); 
        }
    }
}
