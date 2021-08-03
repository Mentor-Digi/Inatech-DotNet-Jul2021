using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class IneligibleException :Exception
    {
        public IneligibleException(String message) : base(message)
        { 
        
        }
    }

}
