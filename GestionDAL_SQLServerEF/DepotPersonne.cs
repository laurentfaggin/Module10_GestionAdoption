using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDAL_SQLServerEF
{
    public class DepotPersonne: GestionAdoptionEntite.IDepotPersonne
    {
        private readonly ApplicationDBContext m_dbContext;

        public DepotPersonne(ApplicationDBContext p_dbContext)
        {
            m_dbContext = p_dbContext ?? throw new ArgumentException (nameof(p_dbContext));
        }

        public void AffichageListeChats()
        {
            ;
        }

        public void AffichagePersonne()
        {
            ;
        }

        public void Create()
        {
            ;
        }

        public void Delete()
        {
            ;
        }

        public void Dispose()
        {
            ;
        }

        public void Read()
        {
            ;
        }

        public void Update()
        {
            ;
        }
    }
}
