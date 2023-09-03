//using GestionAdoptionEntite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDAL_SQLServerEF
{
    public class PersonneDTO
    {
        public int PersonneId { get; set; } = 0;
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";

        public PersonneDTO() {
            ;
        }

        public PersonneDTO(GestionAdoptionEntite.Personne p_personne)
        {
            if (p_personne is null)
            {
                throw new ArgumentNullException(nameof(p_personne));
            }
            this.PersonneId = p_personne.PersonneId;
            this.Nom = p_personne.Nom;
            this.Prenom = p_personne.Prenom;
        }

        public GestionAdoptionEntite.Personne versEntite()
        {
            return new GestionAdoptionEntite.Personne(PersonneId, Nom, Prenom);
        }
    }
}
