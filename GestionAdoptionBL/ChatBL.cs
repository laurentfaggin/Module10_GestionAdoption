using GestionAdoptionEntite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionBL
{
    public class ChatBL
    {
        private readonly IDepotChat m_depotChat;

        public ChatBL(IDepotChat depotChat)
        {
            m_depotChat = depotChat;
        }
    }
}
