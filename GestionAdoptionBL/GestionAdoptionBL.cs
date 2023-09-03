using GestionAdoptionEntite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionBL
{
    public class GestionAdoptionBL:IDisposable
    {
        private readonly IDepotPersonne m_depotPersonne;
        private readonly IDepotChat m_depotChat;

        public GestionAdoptionBL(IDepotPersonne depotPersonne, IDepotChat depotChat)
        {
            m_depotPersonne = depotPersonne;
            m_depotChat = depotChat;
        }

        public void Dispose()
        {
            this.m_depotPersonne?.Dispose();
            this.m_depotChat?.Dispose();
        }
    }
}
