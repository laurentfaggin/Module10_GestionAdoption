using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionEntite
{
    public class Chat
    {
        public int ID { get; set; }
        public string Nom { get; private set; }
        public bool EstAdopte { get; private set; }

        public Chat(int iD, string nom, bool estAdopte)
        {
            this.ID = iD;
            this.Nom = nom;
            this.EstAdopte = estAdopte;
        }

        public override string ToString()
        {
            string res = $"Chat (id: {this.ID}, nom: {this.Nom}, adopte: {this.EstAdopte})";
            return res;
        }
    }
}
