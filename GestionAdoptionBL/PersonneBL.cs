using GestionAdoptionEntite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionBL
{
    public class PersonneBL
    {
        private readonly IDepotPersonne m_depotPersonne;

        public PersonneBL(IDepotPersonne p_depotPersonne)
        {
            m_depotPersonne= p_depotPersonne;
        }



}
