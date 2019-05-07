using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;

namespace Negocios
{
    public class Login
    {
        Data.Login objd = new Data.Login(); 

        public DataTable loginN(Entidades.Login obje)
        {
            return objd.LoginD(obje); 
        }
    }
}
