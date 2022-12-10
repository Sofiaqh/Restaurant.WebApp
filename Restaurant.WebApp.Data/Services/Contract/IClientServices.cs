using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.WebApp.Data
{
    public interface IClientServices
    {
        /// <summary>
        /// Recupera todos los clientes
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Client>> GetClients();
        /// <summary>
        /// Recupera un cliente por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Client> GetClient(int id);
    }
}
