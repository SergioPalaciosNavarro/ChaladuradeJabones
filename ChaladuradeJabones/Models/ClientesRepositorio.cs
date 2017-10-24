using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ChaladuradeJabones.Models
{
    public class ClientesRepositorio: IClientesRepositorio
    {
        private readonly ChaladuraEntities _clientesDataContext;
        public ClientesRepositorio()
        {
            _clientesDataContext = new ChaladuraEntities();
        }
        public IEnumerable<ClientesModel> GetClient()
        {
            IList<ClientesModel> clienteList = new List<ClientesModel>();
            var myQuery = from data in _clientesDataContext.TClientes
                          select data;
            var cliente = myQuery.ToList();
            foreach (var clientData in cliente)
            {
                clienteList.Add(new ClientesModel()
                {
                    ClienteId = clientData.ClienteId,
                    Nombre = clientData.Nombre,
                    Apellido1 = clientData.Apellido1,
                    Apellido2 = clientData.Apellido2,
                    Movil = clientData.Movil,
                    Telefono = clientData.Telefono,
                    Calle = clientData.Calle,
                    Numero = clientData.Numero,
                    Portal = clientData.Portal,
                    Escalera = clientData.Escalera,
                    Piso = clientData.Piso,
                    CP = clientData.CP,
                    Localidad = clientData.Localidad,
                    Provincia = clientData.Provincia,
                    NFacebook = clientData.NFacebook,
                });
            }
            return clienteList;
        }

        public ClientesModel GetClientById(int clienteid)
        {
            var query = from u in _clientesDataContext.TClientes
                        where u.ClienteId == clienteid
                        select u;
            var clientData = query.FirstOrDefault();
            Debug.Assert(clientData != null, nameof(clientData) + " != null");
            var model = new ClientesModel()
                {
                    ClienteId = clientData.ClienteId,
                    Nombre = clientData.Nombre,
                    Apellido1 = clientData.Apellido1,
                    Apellido2 = clientData.Apellido2,
                    Movil = clientData.Movil,
                    Telefono = clientData.Telefono,
                    Calle = clientData.Calle,
                    Numero = clientData.Numero,
                    Portal = clientData.Portal,
                Escalera = clientData.Escalera,
                    Piso = clientData.Piso,
                    CP = clientData.CP,
                    Localidad = clientData.Localidad,
                    Provincia = clientData.Provincia,
                    NFacebook = clientData.NFacebook,

                };
               

            return model;
        }

        public void InsertClient(ClientesModel clientes)
        {
            var clientData = new TClientes()
            {
                ClienteId = clientes.ClienteId,
                Nombre = clientes.Nombre,
                Apellido1 = clientes.Apellido1,
                Apellido2 = clientes.Apellido2,
                Movil = clientes.Movil,
                Telefono = clientes.Telefono,
                Calle = clientes.Calle,
                Numero = clientes.Numero,
                Portal = clientes.Portal,
                Escalera = clientes.Escalera,
                Piso = clientes.Piso,
                CP = clientes.CP,
                Localidad = clientes.Localidad,
                Provincia = clientes.Provincia,
                NFacebook = clientes.NFacebook,
            };
            _clientesDataContext.TClientes.Add(clientData);
            _clientesDataContext.SaveChanges();
        }

        public void DeleteClient(int clienteid)
        {
            var cliente = _clientesDataContext.TClientes.SingleOrDefault(u => u.ClienteId == clienteid);
            Debug.Assert(cliente != null, nameof(cliente) + " != null");
            _clientesDataContext.TClientes.Remove(cliente);
            _clientesDataContext.SaveChanges();
        }

        public void UpdateClient(ClientesModel clienteModel)
        {
            var clientData = _clientesDataContext.TClientes.SingleOrDefault(u => u.ClienteId == clienteModel.ClienteId);
            Debug.Assert(clientData != null, nameof(clientData) + " != null");
            clientData.ClienteId = clienteModel.ClienteId;
            clientData.Nombre = clienteModel.Nombre;
            clientData.Apellido1 = clienteModel.Apellido1;
            clientData.Apellido2 = clienteModel.Apellido2;
            clientData.Movil = clienteModel.Movil;
            clientData.Telefono = clienteModel.Telefono;
            clientData.Calle = clienteModel.Calle;
            clientData.Numero = clienteModel.Numero;
            clientData.Portal = clienteModel.Portal;
            clientData.Escalera = clienteModel.Escalera;
            clientData.Piso = clienteModel.Piso;
            clientData.CP = clienteModel.CP;
            clientData.Localidad = clienteModel.Localidad;
            clientData.Provincia = clienteModel.Provincia;
            clientData.NFacebook = clienteModel.NFacebook;
            _clientesDataContext.SaveChanges();
        }

    }
}