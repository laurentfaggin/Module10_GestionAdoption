namespace GestionAdoptionEntite
{
    public class Personne
    {
        public int PersonneId { get; set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; } 
        //public List<Chat> Chats { get; private set; }
        public Personne(int p_personneId, string p_nom, string p_prenom) { 
            this.PersonneId = p_personneId;
            this.Nom = p_nom;
            this.Prenom = p_prenom;
            //this.Chats = p_chats;
        }

        public override string ToString()
        {
            string res = $"Personne (id: {this.PersonneId}, nom: {this.Nom}, prenom: {this.Prenom})";
            //if (this.Chats!= null)
            //{
            //    foreach(Chat c in Chats)
            //    {
            //        res+= Environment.NewLine + " " + c.ToString() ;
            //    }
            //}
            return res;
        }
    }
}