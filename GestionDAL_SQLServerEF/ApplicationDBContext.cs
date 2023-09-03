using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDAL_SQLServerEF
{
    public class ApplicationDBContext : DbContext
    {
        private IDbContextTransaction? m_transaction;
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {; }

        public DbSet<GestionAdoptionEntite.Personne> Personne => Set<GestionAdoptionEntite.Personne>();   //  = {get; set;}
        public DbSet<GestionAdoptionEntite.Chat> Chat => Set<GestionAdoptionEntite.Chat>();

        public List<GestionAdoptionEntite.Chat> ListeChatsAdoptesParPersonne(int p_id)
        {
            return this.Chat.FromSqlRaw("EXECUTE ListeChatsAdoptesParPersonne {0};", p_id).ToList();
        }

        public List<GestionAdoptionEntite.Chat> ListeChatsNonAdoptes()
        {
            return this.Chat.FromSqlRaw("EXECUTE ListeChatsNonAdoptes").ToList();
        }

        public void BeginTransaction()
        {
            if (m_transaction is not null)
            {
                throw new InvalidOperationException("Une transaction est deja en cours");
            }
            this.m_transaction = this.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (m_transaction is null)
            {
                throw new InvalidOperationException("Une transaction doit etre debutee");
            }
            this.m_transaction.Commit();
            this.m_transaction?.Dispose();
            this.m_transaction = null;
        }

        public void RollBack()
        {
            if (m_transaction is null)
            {
                throw new InvalidOperationException("Une transaction doit etre debutee");
            }
            this.m_transaction.Rollback();
            this.m_transaction?.Dispose();
            this.m_transaction = null;
        }
        
        public void dispose()
        {
            this.m_transaction?.Dispose();
            this.m_transaction = null;
            base.Dispose();
        }

    }
}
