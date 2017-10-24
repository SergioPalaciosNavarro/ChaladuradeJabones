using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaladuradeJabones.Models
{
    public interface IClientesRepositorio
    {
        IEnumerable<ClientesModel> GetClient();
        ClientesModel GetClientById(int clienteid);
        void InsertClient(ClientesModel clientemodel);
        void DeleteClient(int clienteid);
        void UpdateClient(ClientesModel clientemodel);
    }
}
