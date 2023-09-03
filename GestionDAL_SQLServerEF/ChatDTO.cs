using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDAL_SQLServerEF
{
    public class ChatDTO
    {
        public int ID { get; set; } = 0;
        public string Nom { get; set; } = "";
        public bool estAdopte { get; set; } = false;
        [ForeignKey("adoptant")]
        public int Adoptant { get; set; } = 0;

        public ChatDTO() 
        {
            ;
        }

        public ChatDTO(GestionAdoptionEntite.Chat p_chat)
        {
            if(p_chat is null)
            {
                throw new ArgumentNullException(nameof(p_chat));
            }
            ID = p_chat.ID;
            Nom = p_chat.Nom;
            this.estAdopte = p_chat.EstAdopte;
        }

        public GestionAdoptionEntite.Chat versEntite()
        {
            return new GestionAdoptionEntite.Chat(this.ID, this.Nom, this.estAdopte);
        }
    }
}
