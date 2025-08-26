using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Clientes
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            using (DL.PruebaTecnicaEntities context = new DL.PruebaTecnicaEntities())
            {
                var query = context.ClientesView.ToList();
                if (query.Count >0)
                {
                    result.Objects = new List<object>();
                    foreach (var item in query)
                    {
                        ML.Cliente cliente = new ML.Cliente();
                        cliente.Id = item.Id;
                        cliente.Nombre = item.Nombre;
                        cliente.Email = item.Email;
                        cliente.Telefono = item.Telefono;
                        result.Objects.Add(cliente);
                        
                    }
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.Message = "No se enconraron clientes";
                }
            }
            return result;
        }
        public static ML.Result Add(ML.Cliente cliente)
        {
            ML.Result result = new ML.Result();
            using (DL.PruebaTecnicaEntities context = new DL.PruebaTecnicaEntities())
            {
                DL.Clientes clientes = new DL.Clientes();
                clientes.Nombre = cliente.Nombre.ToString();
                clientes.Email = cliente.Email.ToString();
                clientes.Telefono = cliente.Telefono.ToString();
                result.Objects.Add(clientes);
            }
                return result;
        }
    }
}
