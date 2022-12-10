using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.WebApp.Data
{
    public interface IUserServices
    {
        /// <summary>
        /// Recupera la información de los usuario
        /// API suministrada
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Users>> GetAll();
    }
}
