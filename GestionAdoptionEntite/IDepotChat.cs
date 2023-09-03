using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionEntite
{
    public interface IDepotChat: IDisposable
    {
        public void Create();
        public void Read();
        public void Update();
        public void Delete();

        public void ChatsNonAdoptes();

    }
}
